using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record DeviceCodePairedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_code")]
    public DeviceCode? DeviceCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
