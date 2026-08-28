using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="api-endpoint:Customers-BulkDeleteCustomers">BulkDeleteCustomers</see> endpoint.
/// </summary>
public record BulkDeleteCustomersRequest
{
    /// <summary>
    /// The IDs of the <see href="entity:Customer">customer profiles</see> to delete.
    /// </summary>
    [JsonPropertyName("customer_ids")]
    public required IReadOnlyList<string> CustomerIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
