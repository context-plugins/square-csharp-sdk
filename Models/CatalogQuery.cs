using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

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
public record CatalogQuery
{
    /// <summary>
    /// The query expression to specify the key to sort search results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sorted_attribute_query")]
    public CatalogQuerySortedAttribute? SortedAttributeQuery { get; init; }

    /// <summary>
    /// The query filter to return the search result by exact match of the specified attribute name and value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exact_query")]
    public CatalogQueryExact? ExactQuery { get; init; }

    /// <summary>
    /// The query filter to return the search result(s) by exact match of the specified <c>attribute_name</c> and any of
    /// the <c>attribute_values</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("set_query")]
    public CatalogQuerySet? SetQuery { get; init; }

    /// <summary>
    /// The query filter to return the search result whose named attribute values are prefixed by the specified attribute value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prefix_query")]
    public CatalogQueryPrefix? PrefixQuery { get; init; }

    /// <summary>
    /// The query filter to return the search result whose named attribute values fall between the specified range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("range_query")]
    public CatalogQueryRange? RangeQuery { get; init; }

    /// <summary>
    /// The query filter to return the search result whose searchable attribute values contain all of the specified keywords or tokens, independent of the token order or case.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_query")]
    public CatalogQueryText? TextQuery { get; init; }

    /// <summary>
    /// The query filter to return the items containing the specified tax IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items_for_tax_query")]
    public CatalogQueryItemsForTax? ItemsForTaxQuery { get; init; }

    /// <summary>
    /// The query filter to return the items containing the specified modifier list IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items_for_modifier_list_query")]
    public CatalogQueryItemsForModifierList? ItemsForModifierListQuery { get; init; }

    /// <summary>
    /// The query filter to return the items containing the specified item option IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items_for_item_options_query")]
    public CatalogQueryItemsForItemOptions? ItemsForItemOptionsQuery { get; init; }

    /// <summary>
    /// The query filter to return the item variations containing the specified item option value IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variations_for_item_option_values_query")]
    public CatalogQueryItemVariationsForItemOptionValues? ItemVariationsForItemOptionValuesQuery { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
