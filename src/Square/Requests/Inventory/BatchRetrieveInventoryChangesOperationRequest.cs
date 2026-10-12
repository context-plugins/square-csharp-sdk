using Square.Models;

namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the BatchRetrieveInventoryChanges operation.
/// </summary>
public sealed record BatchRetrieveInventoryChangesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BatchRetrieveInventoryChangesRequest Body { get; init; }
}
