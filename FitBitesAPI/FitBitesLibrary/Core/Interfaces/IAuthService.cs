using FitBitesLibrary.Application.Dtos;

namespace FitBitesLibrary.Core.Interfaces;
public interface IAuthService {
    Task<string> Register(RegisterUserDto user);
    Task<(UserDto User, string Token, string RefreshToken)> Login(LoginRequestDto request);
}
