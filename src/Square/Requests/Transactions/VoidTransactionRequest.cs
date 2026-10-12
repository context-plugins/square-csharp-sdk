namespace Square.Requests.Transactions;

/// <summary>
/// The inputs of the VoidTransaction operation.
/// </summary>
public sealed record VoidTransactionRequest
{
    public required string LocationId { get; init; }

    public required string TransactionId { get; init; }
}
