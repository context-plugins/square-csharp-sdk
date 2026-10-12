namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the RetrieveOrder operation.
/// </summary>
public sealed record RetrieveOrderRequest
{
    /// <summary>
    /// The ID of the order to retrieve.
    /// </summary>
    public required string OrderId { get; init; }
}
