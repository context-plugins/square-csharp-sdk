using System.Text.Json.Serialization;

namespace Square.Models;

public record DeviceComponentDetailsCardReaderDetails
{
    /// <summary>
    /// The version of the card reader.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}
