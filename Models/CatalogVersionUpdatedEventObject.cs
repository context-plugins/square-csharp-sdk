using System.Text.Json.Serialization;

namespace Square.Models;

public record CatalogVersionUpdatedEventObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public CatalogVersionUpdatedEventCatalogVersion? CatalogVersion { get; init; }
}
