using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Either the <c>order_entries</c> or <c>orders</c> field is set, depending on whether
/// <c>return_entries</c> is set on the <see href="api-endpoint:Orders-SearchOrders">SearchOrdersRequest</see>.
/// </summary>
public record SearchOrdersResponse
{
    /// <summary>
    /// A list of <see href="entity:OrderEntry">OrderEntries</see> that fit the query
    /// conditions. The list is populated only if <c>return_entries</c> is set to <c>true</c> in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_entries")]
    public IReadOnlyList<OrderEntry>? OrderEntries { get; init; }

    /// <summary>
    /// A list of
    /// <see href="entity:Order">Order</see> objects that match the query conditions. The list is populated only if
    /// <c>return_entries</c> is set to <c>false</c> in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orders")]
    public IReadOnlyList<Order>? Orders { get; init; }

    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If unset,
    /// this is the final response.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// <see href="entity:Error">Errors</see> encountered during the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
