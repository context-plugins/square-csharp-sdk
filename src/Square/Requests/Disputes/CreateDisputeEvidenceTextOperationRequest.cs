using Square.Models;

namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the CreateDisputeEvidenceText operation.
/// </summary>
public sealed record CreateDisputeEvidenceTextOperationRequest
{
    /// <summary>
    /// The ID of the dispute for which you want to upload evidence.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateDisputeEvidenceTextRequest Body { get; init; }
}
