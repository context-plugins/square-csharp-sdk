using Square.Core.Models;
using Square.Models;

namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the CreateDisputeEvidenceFile operation.
/// </summary>
public sealed record CreateDisputeEvidenceFileOperationRequest
{
    /// <summary>
    /// The ID of the dispute for which you want to upload evidence.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// Defines the parameters for a <c>CreateDisputeEvidenceFile</c> request.
    /// </summary>
    public CreateDisputeEvidenceFileRequest? Request { get; init; }

    public BinaryContent? ImageFile { get; init; }
}
