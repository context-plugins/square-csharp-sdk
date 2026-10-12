using Square.Models;

namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the CalculateOrder operation.
/// </summary>
public sealed record CalculateOrderOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CalculateOrderRequest Body { get; init; }
}
