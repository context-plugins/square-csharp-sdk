using Square.Models;

namespace Square.Requests.V1Transactions;

/// <summary>
/// The inputs of the V1UpdateOrder operation.
/// </summary>
public sealed record V1UpdateOrderOperationRequest
{
    /// <summary>
    /// The ID of the order's associated location.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required V1UpdateOrderRequest Body { get; init; }
}
