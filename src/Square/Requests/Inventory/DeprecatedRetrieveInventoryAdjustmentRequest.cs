namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the DeprecatedRetrieveInventoryAdjustment operation.
/// </summary>
public sealed record DeprecatedRetrieveInventoryAdjustmentRequest
{
    /// <summary>
    /// ID of the <see href="entity:InventoryAdjustment">InventoryAdjustment</see> to retrieve.
    /// </summary>
    public required string AdjustmentId { get; init; }
}
