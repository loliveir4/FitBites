using FitBitesLibrary.Core.Enum;

namespace FitBitesLibrary.Core.Entities;
public class Recipe {
    /// <summary>
    /// Unique identifier for the recipe.
    /// </summary>
    [Key]
    public int RecipeId { get; set; }

    /// <summary>
    /// Name of the recipe.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Time of the register
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// URL of the recipe's representative image.
    /// </summary>
    public string ImagemUrl { get; set; }

    /// <summary>
    /// A brief description of the recipe.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Step-by-step instructions for preparing the recipe.
    /// </summary>
    public string StepByStep { get; set; }

    /// <summary>
    /// Indicates whether the recipe is private (visible only to the owner).
    /// </summary>
    public bool IsPrivate { get; set; }

    /// <summary>
    /// The nutritional goal associated with the recipe (e.g., muscle gain, weight loss, etc.).
    /// </summary>
    public NutritionalGoal NutritionalGoal { get; set; }

    /// <summary>
    /// The meal type for this recipe (e.g., breakfast, lunch, dinner).
    /// </summary>
    public MealType MealType { get; set; }

    /// <summary>
    /// The main ingredient of the recipe.
    /// </summary>
    public MainIngredient MainIngredient { get; set; }

    /// <summary>
    /// The cooking method used (e.g., baked, grilled, boiled).
    /// </summary>
    public CookingMethod CookingMethod { get; set; }

    /// <summary>
    /// Identifier of the user who created the recipe.
    /// </summary>
    [ForeignKey("User")]
    public int UserId { get; set; }

    /// <summary>
    /// The user who owns the recipe.
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// List of ingredients required for the recipe.
    /// </summary>
    public List<Ingredient> Ingredients { get; set; }

}
