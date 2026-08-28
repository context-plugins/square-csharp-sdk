using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a custom form field to add to the checkout page to collect more information from buyers during checkout.
/// For more information,
/// see <see href="https://developer.squareup.com/docs/checkout-api/optional-checkout-configurations#specify-checkout-options-1">Specify checkout options</see>.
/// </summary>
public record CustomField
{
    /// <summary>
    /// The title of the custom field.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(50, MinimumLength = 1)]
    public required string Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
