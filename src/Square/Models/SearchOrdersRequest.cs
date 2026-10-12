using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record SearchOrdersRequest
{
    /// <summary>
    /// The location IDs for the orders to query. All locations must belong to
    /// the same merchant.
    /// <para>
    /// Max: 10 location IDs.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Contains query criteria for the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchOrdersQuery? Query { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// <para>
    /// Default: <c>500</c>
    /// Max: <c>1000</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// A Boolean that controls the format of the search results. If <c>true</c>,
    /// <c>SearchOrders</c> returns <see href="entity:OrderEntry">OrderEntry</see> objects. If <c>false</c>, <c>SearchOrders</c>
    /// returns complete order objects.
    /// <para>
    /// Default: <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_entries")]
    public bool? ReturnEntries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
