using Square.Models;

namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the SearchCatalogObjects operation.
/// </summary>
public sealed record SearchCatalogObjectsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchCatalogObjectsRequest Body { get; init; }
}
