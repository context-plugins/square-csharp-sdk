using Square.Models;

namespace Square.Requests.Orders;

/// <summary>
/// The inputs of the PayOrder operation.
/// </summary>
public sealed record PayOrderOperationRequest
{
    /// <summary>
    /// The ID of the order being paid.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required PayOrderRequest Body { get; init; }
}
