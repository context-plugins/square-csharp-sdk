using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="api-endpoint:Subscriptions-SearchSubscriptions">SearchSubscriptions</see> endpoint.
/// </summary>
public record SearchSubscriptionsRequest
{
    /// <summary>
    /// When the total number of resulting subscriptions exceeds the limit of a paged response,
    /// specify the cursor returned from a preceding response here to fetch the next set of results.
    /// If the cursor is unset, the response contains the last page of the results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The upper limit on the number of subscriptions to return
    /// in a paged response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    public int? Limit { get; init; }

    /// <summary>
    /// Represents a query, consisting of specified query expressions, used to search for subscriptions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchSubscriptionsQuery? Query { get; init; }

    /// <summary>
    /// An option to include related information in the response.
    /// <para>
    /// The supported values are:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>actions</c>: to include scheduled actions on the targeted subscriptions.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include")]
    public IReadOnlyList<string>? Include { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
