using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalRefundCreatedEventData
{
    /// <summary>
    /// Name of the created object’s type, <c>"refund"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the created terminal refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public TerminalRefundCreatedEventObject? Object { get; init; }
}
