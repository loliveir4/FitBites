using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FitBitesLibrary.Application.Services;
public class AuthService(FBContext context, IConfiguration config) : IAuthService {
    private readonly FBContext _context = context;
    private readonly IConfiguration _config = config;

    /// <summary>
    /// Registers a new user in the system.
    /// </summary>
    /// <param name="request">User data for registration.</param>
    /// <returns>Success message.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the email already exists.</exception>
    public async Task<string> Register(RegisterUserDto request) {

        if (await _context.Users.AnyAsync(u => u.Email == request.Email))
            throw new InvalidOperationException("Email already exists.");

        var user = new User {
            Username = request.Username,
            Email = request.Email,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
            RefreshToken = GenarateRefreshToken.GenerateRefreshToken(),
            TokenExpiry = DateTime.UtcNow.AddDays(7),
            CreatedAt = DateTime.UtcNow
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return "User registered successfully.";
    }

    /// <summary>
    /// Authenticates a user and generates JWT and refresh tokens.
    /// </summary>
    /// <param name="request">User credentials.</param>
    /// <returns>Object containing user details, JWT token, and refresh token.</returns>
    /// <exception cref="UnauthorizedAccessException">Thrown if the credentials are invalid.</exception>
    public async Task<(UserDto User, string Token, string RefreshToken)> Login(LoginRequestDto request) {

        var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            throw new UnauthorizedAccessException("Invalid credentials.");

        var token = GenerateJwtToken(user);
        user.RefreshToken = GenarateRefreshToken.GenerateRefreshToken();
        user.TokenExpiry = DateTime.UtcNow.AddDays(7);
        await _context.SaveChangesAsync();

        var userDto = new UserDto {
            UserId = user.UserId,
            Username = user.Username,
            Email = user.Email,
            Role = user.Role,
            CreatedAt = user.CreatedAt
        };

        return (userDto, token, user.RefreshToken);
    }

    private string GenerateJwtToken(User user) {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
        new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
        new Claim(JwtRegisteredClaimNames.Email, user.Email),
        new Claim(ClaimTypes.Role, user.Role.ToString())
    };

        var token = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}
