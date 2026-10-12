using Square.Models;

namespace Square.Requests.Events;

/// <summary>
/// The inputs of the SearchEvents operation.
/// </summary>
public sealed record SearchEventsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchEventsRequest Body { get; init; }
}
