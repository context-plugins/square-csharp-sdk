using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the UpdateItemModifierLists operation.
/// </summary>
public sealed record UpdateItemModifierListsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateItemModifierListsRequest Body { get; init; }
}
