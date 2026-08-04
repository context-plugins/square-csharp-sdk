using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Provides information about the subscription event.
/// </summary>
public record SubscriptionEventInfo
{
    /// <summary>
    /// A human-readable explanation for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }

    /// <summary>
    /// Supported info codes of a subscription event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public SubscriptionEventInfoCode? Code { get; init; }
}
