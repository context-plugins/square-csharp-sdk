using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the UpdateWorkweekConfig operation.
/// </summary>
public sealed record UpdateWorkweekConfigOperationRequest
{
    /// <summary>
    /// The UUID for the <c>WorkweekConfig</c> object being updated.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateWorkweekConfigRequest Body { get; init; }
}
