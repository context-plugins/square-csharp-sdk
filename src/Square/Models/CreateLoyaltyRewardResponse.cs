using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A response that includes the loyalty reward created.
/// </summary>
public record CreateLoyaltyRewardResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a contract to redeem loyalty points for a <see href="entity:LoyaltyProgramRewardTier">reward tier</see> discount. Loyalty rewards can be in an ISSUED, REDEEMED, or DELETED state.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-rewards">Manage loyalty rewards</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward")]
    public LoyaltyReward? Reward { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
