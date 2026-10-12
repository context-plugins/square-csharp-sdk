namespace Square.Requests.Inventory;

/// <summary>
/// The inputs of the RetrieveInventoryCount operation.
/// </summary>
public sealed record RetrieveInventoryCountRequest
{
    /// <summary>
    /// ID of the <see href="entity:CatalogObject">CatalogObject</see> to retrieve.
    /// </summary>
    public required string CatalogObjectId { get; init; }

    /// <summary>
    /// The <see href="entity:Location">Location</see> IDs to look up as a comma-separated
    /// list. An empty list queries all locations.
    /// </summary>
    public string? LocationIds { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for the original query.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }
}
