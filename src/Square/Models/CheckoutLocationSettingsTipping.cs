using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CheckoutLocationSettingsTipping
{
    /// <summary>
    /// Set three custom percentage amounts that buyers can select at checkout. If Smart Tip is enabled, this only applies to transactions totaling $10 or more.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentages")]
    public IReadOnlyList<int>? Percentages { get; init; }

    /// <summary>
    /// Enables Smart Tip Amounts. If Smart Tip Amounts is enabled, tipping works as follows:
    /// If a transaction is less than $10, the available tipping options include No Tip, $1, $2, or $3.
    /// If a transaction is $10 or more, the available tipping options include No Tip, 15%, 20%, or 25%.
    /// You can set custom percentage amounts with the <c>percentages</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smart_tipping_enabled")]
    public bool? SmartTippingEnabled { get; init; }

    /// <summary>
    /// Set the pre-selected percentage amounts that appear at checkout. If Smart Tip is enabled, this only applies to transactions totaling $10 or more.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_percent")]
    public int? DefaultPercent { get; init; }

    /// <summary>
    /// Show the Smart Tip Amounts for this location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smart_tips")]
    public IReadOnlyList<Money>? SmartTips { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_smart_tip")]
    public Money? DefaultSmartTip { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
