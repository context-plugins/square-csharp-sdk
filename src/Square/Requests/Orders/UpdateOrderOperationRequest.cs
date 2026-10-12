using Square.Models;

namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the UpdateOrder operation.
/// </summary>
public sealed record UpdateOrderOperationRequest
{
    /// <summary>
    /// The ID of the order to update.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateOrderRequest Body { get; init; }
}
