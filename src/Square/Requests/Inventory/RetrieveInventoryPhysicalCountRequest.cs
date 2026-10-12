namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryPhysicalCount operation.
/// </summary>
public sealed record RetrieveInventoryPhysicalCountRequest
{
    /// <summary>
    /// ID of the
    /// <see href="entity:InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.
    /// </summary>
    public required string PhysicalCountId { get; init; }
}
