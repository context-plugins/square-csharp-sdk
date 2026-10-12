using Square.Models;

namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the CancelTransferOrder operation.
/// </summary>
public sealed record CancelTransferOrderOperationRequest
{
    /// <summary>
    /// The ID of the transfer order to cancel. Must be in STARTED or PARTIALLY_RECEIVED status.
    /// </summary>
    public required string TransferOrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CancelTransferOrderRequest Body { get; init; }
}
