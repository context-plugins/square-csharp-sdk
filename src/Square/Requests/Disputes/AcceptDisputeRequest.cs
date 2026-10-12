namespace Square.Requests.Disputes;

/// <summary>
/// The inputs of the AcceptDispute operation.
/// </summary>
public sealed record AcceptDisputeRequest
{
    /// <summary>
    /// The ID of the dispute you want to accept.
    /// </summary>
    public required string DisputeId { get; init; }
}
