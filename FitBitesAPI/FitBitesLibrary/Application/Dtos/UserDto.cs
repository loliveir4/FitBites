using FitBitesLibrary.Core.Enum;

namespace FitBitesLibrary.Application.Dtos;
/// <summary>
/// Data Transfer Object for returning user information safely.
/// </summary>
public class UserDto {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; }
}
