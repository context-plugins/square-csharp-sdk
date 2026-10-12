using Square.Models;

namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryAdjustmentReason operation.
/// </summary>
public sealed record RetrieveInventoryAdjustmentReasonOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RetrieveInventoryAdjustmentReasonRequest Body { get; init; }
}
