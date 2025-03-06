namespace FitBitesLibrary.Models;

/// <summary>
/// Defines the different cooking methods for recipes.
/// </summary>
public enum CookingMethod {

    /// <summary>
    /// Ready under 20 minutes.
    /// </summary>
    QuickRecipes,

    /// <summary>
    /// Coocked in an air fryer.
    /// </summary>
    AirFryer,

    /// <summary>
    /// Coocked in an Oven.
    /// </summary>
    OvenBaked,

    /// <summary>
    /// Quick recepy for microowave.
    /// </summary>
    Microwave,

    /// <summary>
    /// No needed to cook, raw meals like salad and smothies.
    /// </summary>
    NoCook
}

