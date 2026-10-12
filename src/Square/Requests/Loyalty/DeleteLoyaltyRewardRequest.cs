namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the DeleteLoyaltyReward operation.
/// </summary>
public sealed record DeleteLoyaltyRewardRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to delete.
    /// </summary>
    public required string RewardId { get; init; }
}
