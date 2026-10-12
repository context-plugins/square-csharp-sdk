using Square.Models;

namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the SearchTransferOrders operation.
/// </summary>
public sealed record SearchTransferOrdersOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchTransferOrdersRequest Body { get; init; }
}
