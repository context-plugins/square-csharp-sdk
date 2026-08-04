using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the fields included in the response body from the
/// <see href="api-endpoint:Customers-BulkUpdateCustomers">BulkUpdateCustomers</see> endpoint.
/// </summary>
public record BulkUpdateCustomersResponse
{
    /// <summary>
    /// A map of responses that correspond to individual update requests, represented by
    /// key-value pairs.
    /// <para>
    /// Each key is the customer ID that was specified for an update request and each value
    /// is the corresponding response.
    /// If the request succeeds, the value is the updated customer profile.
    /// If the request fails, the value contains any errors that occurred during the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, UpdateCustomerResponse>? Responses { get; init; }

    /// <summary>
    /// Any top-level errors that prevented the bulk operation from running.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
