namespace FitBitesLibrary.Application.Dtos;
/// <summary>
/// DTO for user login request.
/// </summary>
public class LoginRequestDto {
    public string Email { get; set; }
    public string Password { get; set; }
}
