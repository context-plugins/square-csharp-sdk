using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the SearchLoyaltyRewards operation.
/// </summary>
public sealed record SearchLoyaltyRewardsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchLoyaltyRewardsRequest Body { get; init; }
}
