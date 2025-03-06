namespace FitBitesLibrary.Models;
    /// <summary>
    /// Represents measurement units used for ingredients in recipes.
    /// </summary>
    public enum Unit {
        /// <summary>
        /// Measurement in grams.
        /// Commonly used for solid ingredients like flour, sugar, or meat.
        /// </summary>
        Grams,

        /// <summary>
        /// Measurement in kilograms.
        /// Typically used for larger quantities of solid ingredients.
        /// </summary>
        Kilograms,

        /// <summary>
        /// Measurement in milliliters.
        /// Used for small liquid measurements like oil, milk, or water.
        /// </summary>
        Milliliters,

        /// <summary>
        /// Measurement in liters.
        /// Used for larger liquid quantities like beverages or broth.
        /// </summary>
        Liters,

        /// <summary>
        /// Measurement in teaspoons.
        /// Commonly used for spices, baking powder, or extracts.
        /// </summary>
        Teaspoons,

        /// <summary>
        /// Measurement in tablespoons.
        /// Used for ingredients like butter, sugar, or sauces.
        /// </summary>
        Tablespoons,

        /// <summary>
        /// Measurement in cups.
        /// Often used in baking for flour, sugar, or liquids.
        /// </summary>
        Cups,

        /// <summary>
        /// Measurement in ounces.
        /// Used for both solid and liquid ingredients, especially in US measurements.
        /// </summary>
        Ounces,

        /// <summary>
        /// Measurement in pounds.
        /// Commonly used for meat, vegetables, or large solid portions.
        /// </summary>
        Pounds,

        /// <summary>
        /// Measurement in units (whole pieces).
        /// Used for ingredients like eggs, apples, or whole vegetables.
        /// </summary>
        Units
    }
