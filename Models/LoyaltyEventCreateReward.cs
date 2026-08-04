using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>CREATE_REWARD</c>.
/// </summary>
public record LoyaltyEventCreateReward
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonPropertyName("loyalty_program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyProgramId { get; init; }

    /// <summary>
    /// The Square-assigned ID of the created <see href="entity:LoyaltyReward">loyalty reward</see>.
    /// This field is returned only if the event source is <c>LOYALTY_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward_id")]
    [MaxLength(36)]
    public string? RewardId { get; init; }

    /// <summary>
    /// The loyalty points used to create the reward.
    /// </summary>
    [JsonPropertyName("points")]
    public required int Points { get; init; }
}
