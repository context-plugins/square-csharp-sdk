using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields included in the response body from the
/// <see href="api-endpoint:Customers-BulkCreateCustomers">BulkCreateCustomers</see> endpoint.
/// </summary>
public record BulkCreateCustomersResponse
{
    /// <summary>
    /// A map of responses that correspond to individual create requests, represented by
    /// key-value pairs.
    /// <para>
    /// Each key is the idempotency key that was provided for a create request and each value
    /// is the corresponding response.
    /// If the request succeeds, the value is the new customer profile.
    /// If the request fails, the value contains any errors that occurred during the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, CreateCustomerResponse>? Responses { get; init; }

    /// <summary>
    /// Any top-level errors that prevented the bulk operation from running.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
