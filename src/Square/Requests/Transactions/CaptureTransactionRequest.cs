namespace Square.Requests.Transactions;

/// <summary>
/// The inputs of the CaptureTransaction operation.
/// </summary>
public sealed record CaptureTransactionRequest
{
    public required string LocationId { get; init; }

    public required string TransactionId { get; init; }
}
