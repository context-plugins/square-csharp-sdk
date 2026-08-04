using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record BatchRetrieveCatalogObjectsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A list of <see href="entity:CatalogObject">CatalogObject</see>s returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objects")]
    public IReadOnlyList<CatalogObject>? Objects { get; init; }

    /// <summary>
    /// A list of <see href="entity:CatalogObject">CatalogObject</see>s referenced by the object in the <c>objects</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("related_objects")]
    public IReadOnlyList<CatalogObject>? RelatedObjects { get; init; }
}
