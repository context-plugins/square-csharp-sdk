using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The food and beverage-specific details of a <c>FOOD_AND_BEV</c> item.
/// </summary>
public record CatalogItemFoodAndBeverageDetails
{
    /// <summary>
    /// The calorie count (in the unit of kcal) for the <c>FOOD_AND_BEV</c> type of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calorie_count")]
    public int? CalorieCount { get; init; }

    /// <summary>
    /// The dietary preferences for the <c>FOOD_AND_BEV</c> item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dietary_preferences")]
    public IReadOnlyList<CatalogItemFoodAndBeverageDetailsDietaryPreference>? DietaryPreferences { get; init; }

    /// <summary>
    /// The ingredients for the <c>FOOD_AND_BEV</c> type item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ingredients")]
    public IReadOnlyList<CatalogItemFoodAndBeverageDetailsIngredient>? Ingredients { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
