using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a query, consisting of specified query expressions, used to search for subscriptions.
/// </summary>
public record SearchSubscriptionsQuery
{
    /// <summary>
    /// Represents a set of query expressions (filters) to narrow the scope of targeted subscriptions returned by
    /// the <see href="api-endpoint:Subscriptions-SearchSubscriptions">SearchSubscriptions</see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchSubscriptionsFilter? Filter { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
