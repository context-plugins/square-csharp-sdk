using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="api-endpoint:Customers-BulkRetrieveCustomers">BulkRetrieveCustomers</see> endpoint.
/// </summary>
public record BulkRetrieveCustomersRequest
{
    /// <summary>
    /// The IDs of the <see href="entity:Customer">customer profiles</see> to retrieve.
    /// </summary>
    [JsonPropertyName("customer_ids")]
    public required IReadOnlyList<string> CustomerIds { get; init; }
}
