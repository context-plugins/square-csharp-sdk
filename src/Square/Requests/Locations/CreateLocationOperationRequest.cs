using Square.Models;

namespace Square.Requests.Locations;

/// <summary>
/// The inputs of the CreateLocation operation.
/// </summary>
public sealed record CreateLocationOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateLocationRequest Body { get; init; }
}
