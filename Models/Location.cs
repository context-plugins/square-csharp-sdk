using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents one of a business' <see href="https://developer.squareup.com/docs/locations-api">locations</see>.
/// </summary>
public record Location
{
    /// <summary>
    /// A short generated string of letters and numbers that uniquely identifies this location instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(32)]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the location.
    /// This information appears in the Seller Dashboard as the nickname.
    /// A location name must be unique within a seller account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// The <see href="https://www.iana.org/time-zones">IANA time zone</see> identifier for
    /// the time zone of the location. For example, <c>America/Los_Angeles</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    [MaxLength(30)]
    public string? Timezone { get; init; }

    /// <summary>
    /// The Square features that are enabled for the location.
    /// See <see href="entity:LocationCapability">LocationCapability</see> for possible values.
    /// See <see href="#type-locationcapability">LocationCapability</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyList<LocationCapability>? Capabilities { get; init; }

    /// <summary>
    /// A location's status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public LocationStatus? Status { get; init; }

    /// <summary>
    /// The time when the location was created, in RFC 3339 format.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Working with Dates</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [StringLength(25, MinimumLength = 20)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The ID of the merchant that owns the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    [MaxLength(32)]
    public string? MerchantId { get; init; }

    /// <summary>
    /// Indicates the country associated with another entity, such as a business.
    /// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country? Country { get; init; }

    /// <summary>
    /// The language associated with the location, in
    /// <see href="https://tools.ietf.org/html/bcp47#appendix-A">BCP 47 format</see>.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/general-considerations/language-preferences">Language Preferences</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language_code")]
    [StringLength(5, MinimumLength = 2)]
    public string? LanguageCode { get; init; }

    /// <summary>
    /// Indicates the associated currency for an amount of money. Values correspond
    /// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// The phone number of the location. For example, <c>+1 855-700-6000</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    [MaxLength(17)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The name of the location's overall business. This name is present on receipts and other customer-facing branding, and can be changed no more than three times in a twelve-month period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_name")]
    [MaxLength(255)]
    public string? BusinessName { get; init; }

    /// <summary>
    /// A location's type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public LocationType? Type { get; init; }

    /// <summary>
    /// The website URL of the location.  For example, <c>https://squareup.com</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website_url")]
    [MaxLength(255)]
    public string? WebsiteUrl { get; init; }

    /// <summary>
    /// The hours of operation for a location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_hours")]
    public BusinessHours? BusinessHours { get; init; }

    /// <summary>
    /// The email address of the location. This can be unique to the location and is not always the email address for the business owner or administrator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_email")]
    [MaxLength(255)]
    public string? BusinessEmail { get; init; }

    /// <summary>
    /// The description of the location. For example, <c>Main Street location</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(1024)]
    public string? Description { get; init; }

    /// <summary>
    /// The Twitter username of the location without the '@' symbol. For example, <c>Square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twitter_username")]
    [StringLength(15, MinimumLength = 1)]
    public string? TwitterUsername { get; init; }

    /// <summary>
    /// The Instagram username of the location without the '@' symbol. For example, <c>square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instagram_username")]
    [StringLength(30, MinimumLength = 1)]
    public string? InstagramUsername { get; init; }

    /// <summary>
    /// The Facebook profile URL of the location. The URL should begin with 'facebook.com/'. For example, <c>https://www.facebook.com/square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook_url")]
    [MaxLength(255)]
    public string? FacebookUrl { get; init; }

    /// <summary>
    /// Latitude and longitude coordinates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    public Coordinates? Coordinates { get; init; }

    /// <summary>
    /// The URL of the logo image for the location. When configured in the Seller
    /// Dashboard (Receipts section), the logo appears on transactions (such as receipts and invoices) that Square generates on behalf of the seller.
    /// This image should have a roughly square (1:1) aspect ratio and should be at least 200x200 pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_url")]
    [MaxLength(255)]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The URL of the Point of Sale background image for the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pos_background_url")]
    [MaxLength(255)]
    public string? PosBackgroundUrl { get; init; }

    /// <summary>
    /// A four-digit number that describes the kind of goods or services sold at the location.
    /// The <see href="https://developer.squareup.com/docs/locations-api#initialize-a-merchant-category-code">merchant category code (MCC)</see> of the location as standardized by ISO 18245.
    /// For example, <c>5045</c>, for a location that sells computer goods and software.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    [StringLength(4, MinimumLength = 4)]
    public string? Mcc { get; init; }

    /// <summary>
    /// The URL of a full-format logo image for the location. When configured in the Seller
    /// Dashboard (Receipts section), the logo appears on transactions (such as receipts and invoices) that Square generates on behalf of the seller.
    /// This image can be wider than it is tall and should be at least 1280x648 pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_format_logo_url")]
    public string? FullFormatLogoUrl { get; init; }

    /// <summary>
    /// Identifiers for the location used by various governments for tax purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public TaxIds? TaxIds { get; init; }
}
