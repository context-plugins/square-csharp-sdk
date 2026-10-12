using Square.Models;

namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the UpdateInventoryAdjustment operation.
/// </summary>
public sealed record UpdateInventoryAdjustmentOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateInventoryAdjustmentRequest Body { get; init; }
}
