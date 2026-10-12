using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a query used to search for loyalty events.
/// </summary>
public record LoyaltyEventQuery
{
    /// <summary>
    /// The filtering criteria. If the request specifies multiple filters,
    /// the endpoint uses a logical AND to evaluate them.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public LoyaltyEventFilter? Filter { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
