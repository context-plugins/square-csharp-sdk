using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// SEO data for for a seller's Square Online store.
/// </summary>
public record CatalogEcomSeoData
{
    /// <summary>
    /// The SEO title used for the Square Online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_title")]
    public string? PageTitle { get; init; }

    /// <summary>
    /// The SEO description used for the Square Online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_description")]
    public string? PageDescription { get; init; }

    /// <summary>
    /// The SEO permalink used for the Square Online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("permalink")]
    public string? Permalink { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
