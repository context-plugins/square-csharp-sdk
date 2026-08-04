using System.Text.Json.Serialization;

namespace Square.Models;

public record DeviceCodePairedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_code")]
    public DeviceCode? DeviceCode { get; init; }
}
