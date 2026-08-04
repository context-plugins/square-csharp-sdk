using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Information about a merge operation, which creates a new customer using aggregated properties from two or more existing customers.
/// </summary>
public record CustomerCreatedEventEventContextMerge
{
    /// <summary>
    /// The IDs of the existing customers that were merged and then deleted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_customer_ids")]
    public IReadOnlyList<string?>? FromCustomerIds { get; init; }

    /// <summary>
    /// The ID of the new customer created by the merge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("to_customer_id")]
    public string? ToCustomerId { get; init; }
}
