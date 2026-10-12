namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryAdjustment operation.
/// </summary>
public sealed record RetrieveInventoryAdjustmentRequest
{
    /// <summary>
    /// ID of the <see href="entity:InventoryAdjustment">InventoryAdjustment</see> to retrieve.
    /// </summary>
    public required string AdjustmentId { get; init; }
}
