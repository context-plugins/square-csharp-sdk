using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the CreateLoyaltyReward operation.
/// </summary>
public sealed record CreateLoyaltyRewardOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateLoyaltyRewardRequest Body { get; init; }
}
