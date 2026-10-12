namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the RetrieveDisputeEvidence operation.
/// </summary>
public sealed record RetrieveDisputeEvidenceRequest
{
    /// <summary>
    /// The ID of the dispute from which you want to retrieve evidence metadata.
    /// </summary>
    public required string DisputeId { get; init; }

    /// <summary>
    /// The ID of the evidence to retrieve.
    /// </summary>
    public required string EvidenceId { get; init; }
}
