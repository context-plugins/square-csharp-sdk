using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents a reward tier in a loyalty program. A reward tier defines how buyers can redeem points for a reward, such as the number of points required and the value and scope of the discount. A loyalty program can offer multiple reward tiers.
/// </summary>
public record LoyaltyProgramRewardTier
{
    /// <summary>
    /// The Square-assigned ID of the reward tier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// The points exchanged for the reward tier.
    /// </summary>
    [JsonPropertyName("points")]
    [Minimum(1)]
    public required int Points { get; init; }

    /// <summary>
    /// The name of the reward tier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The timestamp when the reward tier was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// A reference to a Catalog object at a specific version. In general this is
    /// used as an entry point into a graph of catalog objects, where the objects exist
    /// at a specific version.
    /// </summary>
    [JsonPropertyName("pricing_rule_reference")]
    public required CatalogObjectReference PricingRuleReference { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
