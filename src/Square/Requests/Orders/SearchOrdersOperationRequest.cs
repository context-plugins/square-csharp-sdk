using Square.Models;

namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the SearchOrders operation.
/// </summary>
public sealed record SearchOrdersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchOrdersRequest Body { get; init; }
}
