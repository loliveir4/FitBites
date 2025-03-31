using FitBitesLibrary.Core.Enum;

namespace FitBitesLibrary.Core.Entities;

/// <summary>
/// Represents an ingredient that belongs to a single recipe.
/// </summary>
public class Ingredient {
    /// <summary>
    /// Unique identifier for the ingredient.
    /// </summary>
    [Key]
    public int IngredientId { get; set; }

    /// <summary>
    /// Name of the ingredient (e.g., "Chicken Breast").
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The quantity of the ingredient (e.g., 200).
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// The measurement unit for the quantity (e.g., "grams", "cups").
    /// </summary>
    public Unit Unit { get; set; }

    /// <summary>
    /// Foreign key linking the ingredient to a specific recipe.
    /// </summary>
    [ForeignKey("Recipe")]
    public int RecipeId { get; set; }

    /// <summary>
    /// Navigation property that links the ingredient to its recipe.
    /// Used by Entity Framework for relationship management.
    /// </summary>
    public Recipe Recipe { get; set; }
}
