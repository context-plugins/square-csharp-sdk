using System.Text.Json.Serialization;

namespace Square.Models;

public record DeviceCreatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public Device? Device { get; init; }
}
