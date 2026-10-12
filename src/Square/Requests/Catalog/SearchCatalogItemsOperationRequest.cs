using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the SearchCatalogItems operation.
/// </summary>
public sealed record SearchCatalogItemsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchCatalogItemsRequest Body { get; init; }
}
