namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the DeleteDisputeEvidence operation.
/// </summary>
public sealed record DeleteDisputeEvidenceRequest
{
    /// <summary>
    /// The ID of the dispute from which you want to remove evidence.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// The ID of the evidence you want to remove.
    /// </summary>
    public required string EvidenceId { get; init; }
}
