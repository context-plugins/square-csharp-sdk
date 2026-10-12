using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a business that sells with Square.
/// </summary>
public record Merchant
{
    /// <summary>
    /// The Square-issued ID of the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the merchant's overall business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_name")]
    public string? BusinessName { get; init; }

    /// <summary>
    /// Indicates the country associated with another entity, such as a business.
    /// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
    /// </summary>
    [JsonPropertyName("country")]
    public required Country Country { get; init; }

    /// <summary>
    /// The code indicating the <see href="https://developer.squareup.com/docs/build-basics/general-considerations/language-preferences">language preferences</see> of the merchant, in <see href="https://tools.ietf.org/html/bcp47#appendix-A">BCP 47 format</see>. For example, <c>en-US</c> or <c>fr-CA</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; init; }

    /// <summary>
    /// Indicates the associated currency for an amount of money. Values correspond
    /// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public MerchantStatus? Status { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/docs/locations-api#about-the-main-location">main <c>Location</c></see> for this merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("main_location_id")]
    public string? MainLocationId { get; init; }

    /// <summary>
    /// The time when the merchant was created, in RFC 3339 format.
    ///    For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Working with Dates</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
