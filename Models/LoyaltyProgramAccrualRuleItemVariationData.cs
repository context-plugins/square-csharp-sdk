using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents additional data for rules with the <c>ITEM_VARIATION</c> accrual type.
/// </summary>
public record LoyaltyProgramAccrualRuleItemVariationData
{
    /// <summary>
    /// The ID of the <c>ITEM_VARIATION</c> <see href="entity:CatalogObject">catalog object</see> that buyers can purchase to earn
    /// points.
    /// </summary>
    [JsonPropertyName("item_variation_id")]
    [MinLength(1)]
    public required string ItemVariationId { get; init; }
}
