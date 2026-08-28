using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CatalogVersionUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public CatalogVersionUpdatedEventCatalogVersion? CatalogVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
