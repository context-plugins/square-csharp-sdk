using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the SearchTimecards operation.
/// </summary>
public sealed record SearchTimecardsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchTimecardsRequest Body { get; init; }
}
