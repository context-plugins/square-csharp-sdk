using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record DeviceStatus
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public DeviceStatusCategory? Category { get; init; }
}
