namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the SubmitEvidence operation.
/// </summary>
public sealed record SubmitEvidenceRequest
{
    /// <summary>
    /// The ID of the dispute for which you want to submit evidence.
    /// </summary>
    public required string DisputeId { get; init; }
}
