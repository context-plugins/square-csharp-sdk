using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>ListCustomers</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>customers</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListCustomersResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The customer profiles associated with the Square account or an empty object (<c>{}</c>) if none are found.
    /// Only customer profiles with public information (<c>given_name</c>, <c>family_name</c>, <c>company_name</c>, <c>email_address</c>, or
    /// <c>phone_number</c>) are included in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customers")]
    public IReadOnlyList<Customer>? Customers { get; init; }

    /// <summary>
    /// A pagination cursor to retrieve the next set of results for the
    /// original query. A cursor is only present if the request succeeded and additional results
    /// are available.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The total count of customers associated with the Square account. Only customer profiles with public information
    /// (<c>given_name</c>, <c>family_name</c>, <c>company_name</c>, <c>email_address</c>, or <c>phone_number</c>) are counted. This field is present
    /// only if <c>count</c> is set to <c>true</c> in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public long? Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
