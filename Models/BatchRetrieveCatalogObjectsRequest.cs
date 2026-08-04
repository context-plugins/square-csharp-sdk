using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record BatchRetrieveCatalogObjectsRequest
{
    /// <summary>
    /// The IDs of the CatalogObjects to be retrieved.
    /// </summary>
    [JsonPropertyName("object_ids")]
    public required IReadOnlyList<string> ObjectIds { get; init; }

    /// <summary>
    /// If <c>true</c>, the response will include additional objects that are related to the
    /// requested objects. Related objects are defined as any objects referenced by ID by the results in the <c>objects</c> field
    /// of the response. These objects are put in the <c>related_objects</c> field. Setting this to <c>true</c> is
    /// helpful when the objects are needed for immediate display to a user.
    /// This process only goes one level deep. Objects referenced by the related objects will not be included. For example,
    /// <para>
    /// if the <c>objects</c> field of the response contains a CatalogItem, its associated
    /// CatalogCategory objects, CatalogTax objects, CatalogImage objects and
    /// CatalogModifierLists will be returned in the <c>related_objects</c> field of the
    /// response. If the <c>objects</c> field of the response contains a CatalogItemVariation,
    /// its parent CatalogItem will be returned in the <c>related_objects</c> field of
    /// the response.
    /// </para>
    /// <para>
    /// Default value: <c>false</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_related_objects")]
    public bool? IncludeRelatedObjects { get; init; }

    /// <summary>
    /// The specific version of the catalog objects to be included in the response.
    /// This allows you to retrieve historical versions of objects. The specified version value is matched against
    /// the <see href="entity:CatalogObject">CatalogObject</see>s' <c>version</c> attribute. If not included, results will
    /// be from the current version of the catalog.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// Indicates whether to include (<c>true</c>) or not (<c>false</c>) in the response deleted objects, namely, those with the <c>is_deleted</c> attribute set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_deleted_objects")]
    public bool? IncludeDeletedObjects { get; init; }

    /// <summary>
    /// Specifies whether or not to include the <c>path_to_root</c> list for each returned category instance. The <c>path_to_root</c> list consists
    /// of <c>CategoryPathToRootNode</c> objects and specifies the path that starts with the immediate parent category of the returned category
    /// and ends with its root category. If the returned category is a top-level category, the <c>path_to_root</c> list is empty and is not returned
    /// in the response payload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_category_path_to_root")]
    public bool? IncludeCategoryPathToRoot { get; init; }
}
