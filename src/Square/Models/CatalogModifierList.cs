using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A container for a list of modifiers, or a text-based modifier.
/// For text-based modifiers, this represents text configuration for an item. (For example, custom text to print on a t-shirt).
/// For non text-based modifiers, this represents a list of modifiers that can be applied to items at the time of sale.
/// (For example, a list of condiments for a hot dog, or a list of ice cream flavors).
/// Each element of the modifier list is a <c>CatalogObject</c> instance of the <c>MODIFIER</c> type.
/// </summary>
public record CatalogModifierList
{
    /// <summary>
    /// The name of the <c>CatalogModifierList</c> instance. This is a searchable attribute for use in applicable query filters, and its value length is of
    /// Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The position of this <c>CatalogModifierList</c> within a list of <c>CatalogModifierList</c> instances.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// Indicates whether a CatalogModifierList supports multiple selections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_type")]
    public CatalogModifierListSelectionType? SelectionType { get; init; }

    /// <summary>
    /// A non-empty list of <c>CatalogModifier</c> objects to be included in the <c>CatalogModifierList</c>,
    /// for non text-based modifiers when the <c>modifier_type</c> attribute is <c>LIST</c>. Each element of this list
    /// is a <c>CatalogObject</c> instance of the <c>MODIFIER</c> type, containing the following attributes:
    /// <code>
    /// {
    /// "id": "{{catalog_modifier_id}}",
    /// "type": "MODIFIER",
    /// "modifier_data": {{a CatalogModifier instance&gt;}}
    /// }
    /// </code>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiers")]
    public IReadOnlyList<CatalogObject>? Modifiers { get; init; }

    /// <summary>
    /// The IDs of images associated with this <c>CatalogModifierList</c> instance.
    /// Currently these images are not displayed on Square products, but may be displayed in 3rd-party applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_ids")]
    public IReadOnlyList<string>? ImageIds { get; init; }

    /// <summary>
    /// When <c>true</c>, allows multiple quantities of the same modifier to be selected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_quantities")]
    public bool? AllowQuantities { get; init; }

    /// <summary>
    /// True if modifiers belonging to this list can be used conversationally.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_conversational")]
    public bool? IsConversational { get; init; }

    /// <summary>
    /// Defines the type of <c>CatalogModifierList</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_type")]
    public CatalogModifierListModifierType? ModifierType { get; init; }

    /// <summary>
    /// The maximum length, in Unicode points, of the text string of the text-based modifier as represented by
    /// this <c>CatalogModifierList</c> object with the <c>modifier_type</c> set to <c>TEXT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_length")]
    public int? MaxLength { get; init; }

    /// <summary>
    /// Whether the text string must be a non-empty string (<c>true</c>) or not (<c>false</c>) for a text-based modifier
    /// as represented by this <c>CatalogModifierList</c> object with the <c>modifier_type</c> set to <c>TEXT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_required")]
    public bool? TextRequired { get; init; }

    /// <summary>
    /// A note for internal use by the business.
    /// <para>
    /// For example, for a text-based modifier applied to a T-shirt item, if the buyer-supplied text of "Hello, Kitty!"
    /// is to be printed on the T-shirt, this <c>internal_name</c> attribute can be "Use italic face" as
    /// an instruction for the business to follow.
    /// </para>
    /// <para>
    /// For non text-based modifiers, this <c>internal_name</c> attribute can be
    /// used to include SKUs, internal codes, or supplemental descriptions for internal use.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internal_name")]
    [MaxLength(512)]
    public string? InternalName { get; init; }

    /// <summary>
    /// The minimum number of modifiers that must be selected from this list. The value can be overridden with <c>CatalogItemModifierListInfo</c>.
    /// <para>
    /// Values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>0: No selection is required.</description></item>
    ///   <item><description>-1: Default value, the attribute was not set by the client. Treated as no selection required.</description></item>
    ///   <item><description>&amp;gt;0: The required minimum modifier selections. This can be larger than the total <c>CatalogModifiers</c> when <c>allow_quantities</c> is enabled.</description></item>
    ///   <item><description>&amp;lt; -1: Invalid. Treated as no selection required.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_selected_modifiers")]
    public long? MinSelectedModifiers { get; init; }

    /// <summary>
    /// The maximum number of modifiers that must be selected from this list. The value can be overridden with <c>CatalogItemModifierListInfo</c>.
    /// <para>
    /// Values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>0: No maximum limit.</description></item>
    ///   <item><description>-1: Default value, the attribute was not set by the client. Treated as no maximum limit.</description></item>
    ///   <item><description>&amp;gt;0: The maximum total modifier selections. This can be larger than the total <c>CatalogModifiers</c> when <c>allow_quantities</c> is enabled.</description></item>
    ///   <item><description>&amp;lt; -1: Invalid. Treated as no maximum limit.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_selected_modifiers")]
    public long? MaxSelectedModifiers { get; init; }

    /// <summary>
    /// If <c>true</c>, modifiers from this list are hidden from customer receipts. The default value is <c>false</c>.
    /// This setting can be overridden with <c>CatalogItemModifierListInfo.hidden_from_customer_override</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hidden_from_customer")]
    public bool? HiddenFromCustomer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
