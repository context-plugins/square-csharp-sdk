namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the DeleteCatalogObject operation.
/// </summary>
public sealed record DeleteCatalogObjectRequest
{
    /// <summary>
    /// The ID of the catalog object to be deleted. When an object is deleted, other
    /// objects in the graph that depend on that object will be deleted as well (for example, deleting a
    /// catalog item will delete its catalog item variations).
    /// </summary>
    public required string ObjectId { get; init; }
}
