namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the RetrieveTransferOrder operation.
/// </summary>
public sealed record RetrieveTransferOrderRequest
{
    /// <summary>
    /// The ID of the transfer order to retrieve
    /// </summary>
    public required string TransferOrderId { get; init; }
}
