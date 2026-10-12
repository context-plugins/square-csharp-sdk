using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record UpsertCatalogObjectResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The wrapper object for the catalog entries of a given object type.
    /// <para>
    /// Depending on the <c>type</c> attribute value, a <c>CatalogObject</c> instance assumes a type-specific data to yield the corresponding type of catalog object.
    /// </para>
    /// <para>
    /// For example, if <c>type=ITEM</c>, the <c>CatalogObject</c> instance must have the ITEM-specific data set on the <c>item_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>CatalogItem</c> instance.
    /// </para>
    /// <para>
    /// In general, if <c>type=&lt;OBJECT_TYPE&gt;</c>, the <c>CatalogObject</c> instance must have the <c>&lt;OBJECT_TYPE&gt;</c>-specific data set on the <c>&lt;object_type&gt;_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>Catalog&lt;ObjectType&gt;</c> instance.
    /// </para>
    /// <para>
    /// For a more detailed discussion of the Catalog data model, please see the
    /// <see href="https://developer.squareup.com/docs/catalog-api/design-a-catalog">Design a Catalog</see> guide.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object")]
    public CatalogObject? CatalogObject { get; init; }

    /// <summary>
    /// The mapping between client and server IDs for this upsert.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_mappings")]
    public IReadOnlyList<CatalogIdMapping>? IdMappings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
