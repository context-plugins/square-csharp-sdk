using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RedeemLoyaltyReward operation.
/// </summary>
public sealed record RedeemLoyaltyRewardOperationRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to redeem.
    /// </summary>
    public required string RewardId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RedeemLoyaltyRewardRequest Body { get; init; }
}
