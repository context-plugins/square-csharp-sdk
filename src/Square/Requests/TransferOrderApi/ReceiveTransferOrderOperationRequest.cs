using Square.Models;

namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the ReceiveTransferOrder operation.
/// </summary>
public sealed record ReceiveTransferOrderOperationRequest
{
    /// <summary>
    /// The ID of the transfer order to receive items for
    /// </summary>
    public required string TransferOrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required ReceiveTransferOrderRequest Body { get; init; }
}
