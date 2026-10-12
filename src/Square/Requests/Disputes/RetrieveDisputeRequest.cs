namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the RetrieveDispute operation.
/// </summary>
public sealed record RetrieveDisputeRequest
{
    /// <summary>
    /// The ID of the dispute you want more details about.
    /// </summary>
    public required string DisputeId { get; init; }
}
