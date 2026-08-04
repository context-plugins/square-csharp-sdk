using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Options to control how to override the default behavior of the specified modifier.
/// </summary>
public record CatalogModifierOverride
{
    /// <summary>
    /// The ID of the <c>CatalogModifier</c> whose default behavior is being overridden.
    /// </summary>
    [JsonPropertyName("modifier_id")]
    [MinLength(1)]
    public required string ModifierId { get; init; }

    /// <summary>
    /// __Deprecated__: Use <c>on_by_default_override</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_by_default")]
    public bool? OnByDefault { get; init; }

    /// <summary>
    /// Item level overrides for bool attributes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hidden_online_override")]
    public CatalogModifierToggleOverrideType? HiddenOnlineOverride { get; init; }

    /// <summary>
    /// Item level overrides for bool attributes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_by_default_override")]
    public CatalogModifierToggleOverrideType? OnByDefaultOverride { get; init; }
}
