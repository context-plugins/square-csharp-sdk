namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyReward operation.
/// </summary>
public sealed record RetrieveLoyaltyRewardRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to retrieve.
    /// </summary>
    public required string RewardId { get; init; }
}
