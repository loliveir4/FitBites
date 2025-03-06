namespace FitBitesLibrary.Models;

/// <summary>
/// Defines different nutritional goals for recipes.
/// </summary>
public enum NutritionalGoal {
    HighProtein,        // For muscle gain
    LowCarb,            // Low-carb diet
    Keto,               // High-fat, low-carb diet
    Vegan,              // No animal products
    Vegetarian,         // No meat, but may include dairy and eggs
    GlutenFree,         // No gluten for celiac or gluten-sensitive individuals
    LactoseFree,        // No dairy for lactose-intolerant individuals
    HighFiber,          // Rich in fiber for better digestion
    LowFat,             // Low-fat diet for weight management
    MediterraneanDiet   // Olive oil, fish, whole grains, and vegetables
}
