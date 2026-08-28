using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="api-endpoint:Customers-CreateCustomer">CreateCustomer</see> or
/// <see href="api-endpoint:Customers-BulkCreateCustomers">BulkCreateCustomers</see> endpoint.
/// <para>
/// Either <c>errors</c> or <c>customer</c> is present in a given response (never both).
/// </para>
/// </summary>
public record CreateCustomerResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a Square customer profile in the Customer Directory of a Square seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
