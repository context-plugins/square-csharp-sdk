using Square.Models;

namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the BatchChangeInventory operation.
/// </summary>
public sealed record BatchChangeInventoryOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BatchChangeInventoryRequest Body { get; init; }
}
