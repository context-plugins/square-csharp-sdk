using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>REDEEM_REWARD</c>.
/// </summary>
public record LoyaltyEventRedeemReward
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonPropertyName("loyalty_program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyProgramId { get; init; }

    /// <summary>
    /// The ID of the redeemed <see href="entity:LoyaltyReward">loyalty reward</see>.
    /// This field is returned only if the event source is <c>LOYALTY_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward_id")]
    [MaxLength(36)]
    public string? RewardId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Order">order</see> that redeemed the reward.
    /// This field is returned only if the Orders API is used to process orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }
}
