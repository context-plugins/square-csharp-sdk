using Square.Models;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the SearchLoyaltyEvents operation.
/// </summary>
public sealed record SearchLoyaltyEventsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchLoyaltyEventsRequest Body { get; init; }
}
