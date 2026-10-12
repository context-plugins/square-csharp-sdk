using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the UpdateBreakType operation.
/// </summary>
public sealed record UpdateBreakTypeOperationRequest
{
    /// <summary>
    /// The UUID for the <c>BreakType</c> being updated.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateBreakTypeRequest Body { get; init; }
}
