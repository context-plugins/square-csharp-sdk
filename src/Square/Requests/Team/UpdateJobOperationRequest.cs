using Square.Models;

namespace Square.Requests.Team;

/// <summary>
/// The inputs of the UpdateJob operation.
/// </summary>
public sealed record UpdateJobOperationRequest
{
    /// <summary>
    /// The ID of the job to update.
    /// </summary>
    public required string JobId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateJobRequest Body { get; init; }
}
