namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the DeleteTransferOrder operation.
/// </summary>
public sealed record DeleteTransferOrderRequest
{
    /// <summary>
    /// The ID of the transfer order to delete
    /// </summary>
    public required string TransferOrderId { get; init; }

    /// <summary>
    /// Version for optimistic concurrency
    /// </summary>
    public long? Version { get; init; }
}
