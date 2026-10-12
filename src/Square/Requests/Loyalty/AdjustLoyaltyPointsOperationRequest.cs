using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the AdjustLoyaltyPoints operation.
/// </summary>
public sealed record AdjustLoyaltyPointsOperationRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:LoyaltyAccount">loyalty account</see>.
    /// </summary>
    public required string AccountId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required AdjustLoyaltyPointsRequest Body { get; init; }
}
