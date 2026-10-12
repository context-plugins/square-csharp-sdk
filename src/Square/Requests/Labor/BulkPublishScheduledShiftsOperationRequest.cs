using Square.Models;

namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the BulkPublishScheduledShifts operation.
/// </summary>
public sealed record BulkPublishScheduledShiftsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkPublishScheduledShiftsRequest Body { get; init; }
}
