using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a postal address in a country.
/// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
/// </summary>
public record Address
{
    /// <summary>
    /// The first line of the address.
    /// <para>
    /// Fields that start with <c>address_line</c> provide the address's most specific
    /// details, like street number, street name, and building name. They do *not*
    /// provide less specific details like city, state/province, or country (these
    /// details are provided in other fields).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_1")]
    public string? AddressLine1 { get; init; }

    /// <summary>
    /// The second line of the address, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_2")]
    public string? AddressLine2 { get; init; }

    /// <summary>
    /// The third line of the address, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_3")]
    public string? AddressLine3 { get; init; }

    /// <summary>
    /// The city or town of the address. For a full list of field meanings by country, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    public string? Locality { get; init; }

    /// <summary>
    /// A civil region within the address's <c>locality</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality")]
    public string? Sublocality { get; init; }

    /// <summary>
    /// A civil region within the address's <c>sublocality</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality_2")]
    public string? Sublocality2 { get; init; }

    /// <summary>
    /// A civil region within the address's <c>sublocality_2</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality_3")]
    public string? Sublocality3 { get; init; }

    /// <summary>
    /// A civil entity within the address's country. In the US, this
    /// is the state. For a full list of field meanings by country, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_1")]
    public string? AdministrativeDistrictLevel1 { get; init; }

    /// <summary>
    /// A civil entity within the address's <c>administrative_district_level_1</c>.
    /// In the US, this is the county.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_2")]
    public string? AdministrativeDistrictLevel2 { get; init; }

    /// <summary>
    /// A civil entity within the address's <c>administrative_district_level_2</c>,
    /// if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_3")]
    public string? AdministrativeDistrictLevel3 { get; init; }

    /// <summary>
    /// The address's postal code. For a full list of field meanings by country, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// Indicates the country associated with another entity, such as a business.
    /// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country? Country { get; init; }

    /// <summary>
    /// Optional first name when it's representing recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// Optional last name when it's representing recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }
}
