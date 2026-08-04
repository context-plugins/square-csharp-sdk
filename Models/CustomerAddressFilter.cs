using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The customer address filter. This filter is used in a <see href="entity:CustomerCustomAttributeFilterValue">CustomerCustomAttributeFilterValue</see> filter when
/// searching by an <c>Address</c>-type custom attribute.
/// </summary>
public record CustomerAddressFilter
{
    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public CustomerTextFilter? PostalCode { get; init; }

    /// <summary>
    /// Indicates the country associated with another entity, such as a business.
    /// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Country? Country { get; init; }
}
