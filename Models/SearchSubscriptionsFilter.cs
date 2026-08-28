using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a set of query expressions (filters) to narrow the scope of targeted subscriptions returned by
/// the <see href="api-endpoint:Subscriptions-SearchSubscriptions">SearchSubscriptions</see> endpoint.
/// </summary>
public record SearchSubscriptionsFilter
{
    /// <summary>
    /// A filter to select subscriptions based on the subscribing customer IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ids")]
    public IReadOnlyList<string?>? CustomerIds { get; init; }

    /// <summary>
    /// A filter to select subscriptions based on the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string?>? LocationIds { get; init; }

    /// <summary>
    /// A filter to select subscriptions based on the source application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_names")]
    public IReadOnlyList<string?>? SourceNames { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
