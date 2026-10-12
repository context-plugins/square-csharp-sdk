using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CatalogVersionUpdatedEventData
{
    /// <summary>
    /// Name of the affected object’s type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public CatalogVersionUpdatedEventObject? Object { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
