using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the CalculateLoyaltyPoints operation.
/// </summary>
public sealed record CalculateLoyaltyPointsOperationRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyProgram">loyalty program</see>, which defines the rules for accruing points.
    /// </summary>
    public required string ProgramId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CalculateLoyaltyPointsRequest Body { get; init; }
}
