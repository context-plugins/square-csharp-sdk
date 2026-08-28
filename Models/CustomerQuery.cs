using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents filtering and sorting criteria for a <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> request.
/// </summary>
public record CustomerQuery
{
    /// <summary>
    /// Represents the filtering criteria in a <see href="entity:CustomerQuery">search query</see> that defines how to filter
    /// customer profiles returned in <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public CustomerFilter? Filter { get; init; }

    /// <summary>
    /// Represents the sorting criteria in a <see href="entity:CustomerQuery">search query</see> that defines how to sort
    /// customer profiles returned in <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public CustomerSort? Sort { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
