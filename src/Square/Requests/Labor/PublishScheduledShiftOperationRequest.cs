using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the PublishScheduledShift operation.
/// </summary>
public sealed record PublishScheduledShiftOperationRequest
{
    /// <summary>
    /// The ID of the scheduled shift to publish.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required PublishScheduledShiftRequest Body { get; init; }
}
