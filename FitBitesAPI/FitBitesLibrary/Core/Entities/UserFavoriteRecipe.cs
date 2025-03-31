namespace FitBitesLibrary.Core.Entities;

/// <summary>
/// Represents a many-to-many relationship between User and Recipe for favoriting recipes.
/// </summary>
public class UserFavoriteRecipe {
    public int UserId { get; set; } // Foreign Key for User
    public User User { get; set; } // Navigation Property
    public int RecipeId { get; set; } // Foreign Key for Recipe
    public Recipe Recipe { get; set; } // Navigation Property

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Timestamp when favorited
}

