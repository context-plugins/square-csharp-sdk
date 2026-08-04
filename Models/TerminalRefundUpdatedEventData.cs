using System.Text.Json.Serialization;

namespace Square.Models;

public record TerminalRefundUpdatedEventData
{
    /// <summary>
    /// Name of the updated object’s type, <c>"refund"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the updated terminal refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public TerminalRefundUpdatedEventObject? Object { get; init; }
}
