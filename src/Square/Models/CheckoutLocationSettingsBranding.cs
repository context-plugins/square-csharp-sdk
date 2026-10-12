using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record CheckoutLocationSettingsBranding
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("header_type")]
    public CheckoutLocationSettingsBrandingHeaderType? HeaderType { get; init; }

    /// <summary>
    /// The HTML-supported hex color for the button on the checkout page (for example, "#FFFFFF").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("button_color")]
    [StringLength(7, MinimumLength = 7)]
    public string? ButtonColor { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("button_shape")]
    public CheckoutLocationSettingsBrandingButtonShape? ButtonShape { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
