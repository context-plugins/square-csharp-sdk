namespace Square.Requests.Transactions;

/// <summary>
/// The inputs of the RetrieveTransaction operation.
/// </summary>
public sealed record RetrieveTransactionRequest
{
    /// <summary>
    /// The ID of the transaction's associated location.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The ID of the transaction to retrieve.
    /// </summary>
    public required string TransactionId { get; init; }
}
