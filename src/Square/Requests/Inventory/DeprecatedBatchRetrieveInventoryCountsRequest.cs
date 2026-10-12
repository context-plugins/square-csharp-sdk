using Square.Models;

namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the DeprecatedBatchRetrieveInventoryCounts operation.
/// </summary>
public sealed record DeprecatedBatchRetrieveInventoryCountsRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BatchRetrieveInventoryCountsRequest Body { get; init; }
}
