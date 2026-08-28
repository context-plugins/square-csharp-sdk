using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Describes the ingredient used in a <c>FOOD_AND_BEV</c> item.
/// </summary>
public record CatalogItemFoodAndBeverageDetailsIngredient
{
    /// <summary>
    /// The type of dietary preference for the <c>FOOD_AND_BEV</c> type of items and integredients.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public CatalogItemFoodAndBeverageDetailsDietaryPreferenceType? Type { get; init; }

    /// <summary>
    /// Standard ingredients for food and beverage items that are recommended on item creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("standard_name")]
    public CatalogItemFoodAndBeverageDetailsIngredientStandardIngredient? StandardName { get; init; }

    /// <summary>
    /// The name of a custom user-defined ingredient. This should be null if it's a standard dietary preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_name")]
    public string? CustomName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
