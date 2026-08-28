using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Controls how a modifier list is applied to a specific item. This object allows for item-specific customization of modifier list behavior
/// and provides the ability to override global modifier list settings.
/// </summary>
public record CatalogItemModifierListInfo
{
    /// <summary>
    /// The ID of the <c>CatalogModifierList</c> controlled by this <c>CatalogModifierListInfo</c>.
    /// </summary>
    [JsonPropertyName("modifier_list_id")]
    [MinLength(1)]
    public required string ModifierListId { get; init; }

    /// <summary>
    /// A set of <c>CatalogModifierOverride</c> objects that override default modifier settings for this item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_overrides")]
    public IReadOnlyList<CatalogModifierOverride?>? ModifierOverrides { get; init; }

    /// <summary>
    /// The minimum number of modifiers that must be selected from this modifier list.
    /// Values:
    /// <para>
    /// - 0: No selection is required.
    /// - -1: Default value, the attribute was not set by the client. When <c>max_selected_modifiers</c> is
    /// also -1, use the minimum and maximum selection values set on the <c>CatalogItemModifierList</c>.
    /// - &amp;gt;0: The required minimum modifier selections. This can be larger than the total <c>CatalogModifiers</c> when <c>allow_quantities</c> is enabled.
    /// - &amp;lt; -1: Invalid. Treated as no selection required.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_selected_modifiers")]
    public int? MinSelectedModifiers { get; init; }

    /// <summary>
    /// The maximum number of modifiers that can be selected.
    /// Values:
    /// <para>
    /// - 0: No maximum limit.
    /// - -1: Default value, the attribute was not set by the client. When <c>min_selected_modifiers</c> is
    /// also -1, use the minimum and maximum selection values set on the <c>CatalogItemModifierList</c>.
    /// - &amp;gt;0: The maximum total modifier selections. This can be larger than the total <c>CatalogModifiers</c> when <c>allow_quantities</c> is enabled.
    /// - &amp;lt; -1: Invalid. Treated as no maximum limit.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_selected_modifiers")]
    public int? MaxSelectedModifiers { get; init; }

    /// <summary>
    /// If <c>true</c>, enable this <c>CatalogModifierList</c>. The default value is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// The position of this <c>CatalogItemModifierListInfo</c> object within the <c>modifier_list_info</c> list applied
    /// to a <c>CatalogItem</c> instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// Item level overrides for bool attributes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_quantities")]
    public CatalogModifierToggleOverrideType? AllowQuantities { get; init; }

    /// <summary>
    /// Item level overrides for bool attributes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_conversational")]
    public CatalogModifierToggleOverrideType? IsConversational { get; init; }

    /// <summary>
    /// Item level overrides for bool attributes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hidden_from_customer_override")]
    public CatalogModifierToggleOverrideType? HiddenFromCustomerOverride { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
