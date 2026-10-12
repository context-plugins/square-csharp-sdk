using Square.Models;

namespace Square.Requests.Bookings;

/// <summary>
/// The inputs of the SearchAvailability operation.
/// </summary>
public sealed record SearchAvailabilityOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchAvailabilityRequest Body { get; init; }
}
