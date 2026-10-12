using Square.Models;

namespace Square.Requests.Locations;

/// <summary>
/// The inputs of the UpdateLocation operation.
/// </summary>
public sealed record UpdateLocationOperationRequest
{
    /// <summary>
    /// The ID of the location to update.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateLocationRequest Body { get; init; }
}
