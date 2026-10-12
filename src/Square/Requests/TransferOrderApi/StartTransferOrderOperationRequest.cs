using Square.Models;

namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the StartTransferOrder operation.
/// </summary>
public sealed record StartTransferOrderOperationRequest
{
    /// <summary>
    /// The ID of the transfer order to start. Must be in DRAFT status.
    /// </summary>
    public required string TransferOrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required StartTransferOrderRequest Body { get; init; }
}
