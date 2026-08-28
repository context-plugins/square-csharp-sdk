using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents information about the application used to generate a change.
/// </summary>
public record SourceApplication
{
    /// <summary>
    /// Indicates the Square product used to generate a change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product")]
    public Product? Product { get; init; }

    /// <summary>
    /// __Read only__ The Square-assigned ID of the application. This field is used only if the
    /// <see href="entity:Product">product</see> type is <c>EXTERNAL_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; init; }

    /// <summary>
    /// __Read only__ The display name of the application
    /// (for example, <c>"Custom Application"</c> or <c>"Square POS 4.74 for Android"</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
