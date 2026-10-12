namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the DeprecatedRetrieveInventoryPhysicalCount operation.
/// </summary>
public sealed record DeprecatedRetrieveInventoryPhysicalCountRequest
{
    /// <summary>
    /// ID of the
    /// <see href="entity:InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.
    /// </summary>
    public required string PhysicalCountId { get; init; }
}
