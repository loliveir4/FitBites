namespace FitBitesLibrary.Data;
public class User {
    /// <summary>
    /// Unique identifier for the user.
    /// </summary>
    [Key]
    public int UserId { get; set; }

    /// <summary>
    /// The username used for login.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The user's email address used for login and communication.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Hashed password for secure authentication.
    /// </summary>
    public string PasswordHash { get; set; }

    /// <summary>
    /// The user's role in the system (e.g., Admin, User).
    /// Defaults to a regular user role.
    /// </summary>
    public UserRole Role { get; set; } = UserRole.User;

    // Token Management

    /// <summary>
    /// Refresh token used for authentication renewal.
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Expiry date for the refresh token.
    /// </summary>
    public DateTime TokenExpiry { get; set; }

    /// <summary>
    /// The date and time when the user was created.
    /// Defaults to the current UTC time.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// List of recipes created by the user.
    /// </summary>
    public List<Recipe> Recipes { get; set; }
}

