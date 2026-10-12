namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the ListInventoryAdjustmentReasons operation.
/// </summary>
public sealed record ListInventoryAdjustmentReasonsRequest
{
    /// <summary>
    /// Indicates whether the response should include deleted custom inventory
    /// adjustment reasons. The default value is <c>false</c>.
    /// </summary>
    public bool IncludeDeleted { get; init; } = false;

    /// <summary>
    /// Indicates whether the response should include Square-generated system
    /// inventory adjustment reason codes that cannot be used to write adjustments
    /// from the Connect API, such as <c>SALE</c>, <c>RECOUNT</c>, <c>TRANSFER</c>, <c>IN_TRANSIT</c>,
    /// and <c>CANCELED_SALE</c>. The default value is <c>false</c>.
    /// </summary>
    public bool IncludeSystemCodes { get; init; } = false;
}
