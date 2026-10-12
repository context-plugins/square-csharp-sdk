using Square.Models;

namespace Square.Requests.TransferOrderApi;

/// <summary>
/// The inputs of the UpdateTransferOrder operation.
/// </summary>
public sealed record UpdateTransferOrderOperationRequest
{
    /// <summary>
    /// The ID of the transfer order to update
    /// </summary>
    public required string TransferOrderId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateTransferOrderRequest Body { get; init; }
}
