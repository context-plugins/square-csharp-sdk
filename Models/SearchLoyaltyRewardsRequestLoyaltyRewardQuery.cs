using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The set of search requirements.
/// </summary>
public record SearchLoyaltyRewardsRequestLoyaltyRewardQuery
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyAccount">loyalty account</see> to which the loyalty reward belongs.
    /// </summary>
    [JsonPropertyName("loyalty_account_id")]
    [MinLength(1)]
    public required string LoyaltyAccountId { get; init; }

    /// <summary>
    /// The status of the loyalty reward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public LoyaltyRewardStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
