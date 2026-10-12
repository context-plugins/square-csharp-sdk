using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CatalogVersionUpdatedEventCatalogVersion
{
    /// <summary>
    /// Last modification timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
