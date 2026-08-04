using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record SearchCatalogObjectsRequest
{
    /// <summary>
    /// The pagination cursor returned in the previous response. Leave unset for an initial request.
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The desired set of object types to appear in the search results.
    /// <para>
    /// If this is unspecified, the operation returns objects of all the top level types at the version
    /// of the Square API used to make the request. Object types that are nested onto other object types
    /// are not included in the defaults.
    /// </para>
    /// <para>
    /// At the current API version the default object types are:
    /// ITEM, CATEGORY, TAX, DISCOUNT, MODIFIER_LIST,
    /// PRICING_RULE, PRODUCT_SET, TIME_PERIOD, MEASUREMENT_UNIT,
    /// SUBSCRIPTION_PLAN, ITEM_OPTION, CUSTOM_ATTRIBUTE_DEFINITION, QUICK_AMOUNT_SETTINGS.
    /// </para>
    /// <para>
    /// Note that if you wish for the query to return objects belonging to nested types (i.e., COMPONENT, IMAGE,
    /// ITEM_OPTION_VAL, ITEM_VARIATION, or MODIFIER), you must explicitly include all the types of interest
    /// in this field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_types")]
    public IReadOnlyList<CatalogObjectType>? ObjectTypes { get; init; }

    /// <summary>
    /// If <c>true</c>, deleted objects will be included in the results. Defaults to <c>false</c>. Deleted objects will have their <c>is_deleted</c> field set to <c>true</c>. If <c>include_deleted_objects</c> is <c>true</c>, then the <c>include_category_path_to_root</c> request parameter must be <c>false</c>. Both properties cannot be <c>true</c> at the same time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_deleted_objects")]
    public bool? IncludeDeletedObjects { get; init; }

    /// <summary>
    /// If <c>true</c>, the response will include additional objects that are related to the
    /// requested objects. Related objects are objects that are referenced by object ID by the objects
    /// in the response. This is helpful if the objects are being fetched for immediate display to a user.
    /// This process only goes one level deep. Objects referenced by the related objects will not be included.
    /// For example:
    /// <para>
    /// If the <c>objects</c> field of the response contains a CatalogItem, its associated
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
    /// Return objects modified after this <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>, in RFC 3339
    /// format, e.g., <c>2016-09-04T23:59:33.123Z</c>. The timestamp is exclusive - objects with a
    /// timestamp equal to <c>begin_time</c> will not be included in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// A query composed of one or more different types of filters to narrow the scope of targeted objects when calling the <c>SearchCatalogObjects</c> endpoint.
    /// <para>
    /// Although a query can have multiple filters, only certain query types can be combined per call to <see href="api-endpoint:Catalog-SearchCatalogObjects">SearchCatalogObjects</see>.
    /// Any combination of the following types may be used together:
    /// - <see href="entity:CatalogQueryExact">exact_query</see>
    /// - <see href="entity:CatalogQueryPrefix">prefix_query</see>
    /// - <see href="entity:CatalogQueryRange">range_query</see>
    /// - <see href="entity:CatalogQuerySortedAttribute">sorted_attribute_query</see>
    /// - <see href="entity:CatalogQueryText">text_query</see>
    /// </para>
    /// <para>
    /// All other query types cannot be combined with any others.
    /// </para>
    /// <para>
    /// When a query filter is based on an attribute, the attribute must be searchable.
    /// Searchable attributes are listed as follows, along their parent types that can be searched for with applicable query filters.
    /// </para>
    /// <para>
    /// Searchable attribute and objects queryable by searchable attributes:
    /// - <c>name</c>:  <c>CatalogItem</c>, <c>CatalogItemVariation</c>, <c>CatalogCategory</c>, <c>CatalogTax</c>, <c>CatalogDiscount</c>, <c>CatalogModifier</c>, <c>CatalogModifierList</c>, <c>CatalogItemOption</c>, <c>CatalogItemOptionValue</c>
    /// - <c>description</c>: <c>CatalogItem</c>, <c>CatalogItemOptionValue</c>
    /// - <c>abbreviation</c>: <c>CatalogItem</c>
    /// - <c>upc</c>: <c>CatalogItemVariation</c>
    /// - <c>sku</c>: <c>CatalogItemVariation</c>
    /// - <c>caption</c>: <c>CatalogImage</c>
    /// - <c>display_name</c>: <c>CatalogItemOption</c>
    /// </para>
    /// <para>
    /// For example, to search for <see href="entity:CatalogItem">CatalogItem</see> objects by searchable attributes, you can use
    /// the <c>"name"</c>, <c>"description"</c>, or <c>"abbreviation"</c> attribute in an applicable query filter.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public CatalogQuery? Query { get; init; }

    /// <summary>
    /// A limit on the number of results to be returned in a single page. The limit is advisory -
    /// the implementation may return more or fewer results. If the supplied limit is negative, zero, or
    /// is higher than the maximum limit of 1,000, it will be ignored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// Specifies whether or not to include the <c>path_to_root</c> list for each returned category instance. The <c>path_to_root</c> list consists of <c>CategoryPathToRootNode</c> objects and specifies the path that starts with the immediate parent category of the returned category and ends with its root category. If the returned category is a top-level category, the <c>path_to_root</c> list is empty and is not returned in the response payload. If <c>include_category_path_to_root</c> is <c>true</c>, then the <c>include_deleted_objects</c> request parameter must be <c>false</c>. Both properties cannot be <c>true</c> at the same time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_category_path_to_root")]
    public bool? IncludeCategoryPathToRoot { get; init; }
}
