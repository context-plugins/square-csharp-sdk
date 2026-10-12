namespace Square.Requests.V1Transactions;

/// <summary>
/// The inputs of the V1RetrieveOrder operation.
/// </summary>
public sealed record V1RetrieveOrderRequest
{
    /// <summary>
    /// The ID of the order's associated location.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint
    /// </summary>
    public required string OrderId { get; init; }
}
