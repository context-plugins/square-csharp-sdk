using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an input into a call to <see href="api-endpoint:Vendors-SearchVendors">SearchVendors</see>.
/// </summary>
public record SearchVendorsRequest
{
    /// <summary>
    /// Defines supported query expressions to search for vendors by.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchVendorsRequestFilter? Filter { get; init; }

    /// <summary>
    /// Defines a sorter used to sort results from <see href="api-endpoint:Vendors-SearchVendors">SearchVendors</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public SearchVendorsRequestSort? Sort { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for the original query.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}
