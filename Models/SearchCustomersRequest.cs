using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the request body of a request to the
/// <c>SearchCustomers</c> endpoint.
/// </summary>
public record SearchCustomersRequest
{
    /// <summary>
    /// Include the pagination cursor in subsequent calls to this endpoint to retrieve
    /// the next set of results associated with the original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// If the specified limit is invalid, Square returns a <c>400 VALUE_TOO_LOW</c> or <c>400 VALUE_TOO_HIGH</c> error. The default value is 100.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public long? Limit { get; init; }

    /// <summary>
    /// Represents filtering and sorting criteria for a <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public CustomerQuery? Query { get; init; }

    /// <summary>
    /// Indicates whether to return the total count of matching customers in the <c>count</c> field of the response.
    /// <para>
    /// The default value is <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public bool? Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
