using Microsoft.AspNetCore.Mvc;

namespace FitBitesAPI.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase {
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService) => _authService = authService;

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto user) {
        try {
            var result = await _authService.Register(user);
            return Ok(result);
        }
        catch (InvalidOperationException ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto request) {
        try {
            var (user, token, refreshToken) = await _authService.Login(request);
            return Ok(new { user, token, refreshToken });
        }
        catch (UnauthorizedAccessException ex) {
            return Unauthorized(ex.Message);
        }
    }
}
