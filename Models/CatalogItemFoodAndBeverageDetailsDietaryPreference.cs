using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Dietary preferences that can be assigned to an <c>FOOD_AND_BEV</c> item and its ingredients.
/// </summary>
public record CatalogItemFoodAndBeverageDetailsDietaryPreference
{
    /// <summary>
    /// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public CatalogItemFoodAndBeverageDetailsDietaryPreferenceType? Type { get; init; }

    /// <summary>
    /// Standard dietary preferences for food and beverage items that are recommended on item creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standard_name")]
    public CatalogItemFoodAndBeverageDetailsDietaryPreferenceStandardDietaryPreference? StandardName { get; init; }

    /// <summary>
    /// The name of a user-defined custom dietary preference. This should be null if it's a standard dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_name")]
    public string? CustomName { get; init; }
}
