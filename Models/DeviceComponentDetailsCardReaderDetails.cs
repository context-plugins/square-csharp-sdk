using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record DeviceComponentDetailsCardReaderDetails
{
    /// <summary>
    /// The version of the card reader.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
