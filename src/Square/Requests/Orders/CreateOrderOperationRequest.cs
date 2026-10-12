using Square.Models;

namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the CreateOrder operation.
/// </summary>
public sealed record CreateOrderOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateOrderRequest Body { get; init; }
}
