using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A type-specific filter used in a <see href="entity:CustomerCustomAttributeFilter">custom attribute filter</see> to search based on the value
/// of a customer-related <see href="entity:CustomAttribute">custom attribute</see>.
/// </summary>
public record CustomerCustomAttributeFilterValue
{
    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public CustomerTextFilter? Email { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public CustomerTextFilter? Phone { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public CustomerTextFilter? Text { get; init; }

    /// <summary>
    /// A filter to select resources based on an exact field value. For any given
    /// value, the value can only be in one property. Depending on the field, either
    /// all properties can be set or only a subset will be available.
    /// <para>
    /// Refer to the documentation of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection")]
    public FilterValue? Selection { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public TimeRange? Date { get; init; }

    /// <summary>
    /// Specifies a decimal number range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public FloatNumberRange? Number { get; init; }

    /// <summary>
    /// A filter for a query based on the value of a <c>Boolean</c>-type custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boolean")]
    public bool? Boolean { get; init; }

    /// <summary>
    /// The customer address filter. This filter is used in a <see href="entity:CustomerCustomAttributeFilterValue">CustomerCustomAttributeFilterValue</see> filter when
    /// searching by an <c>Address</c>-type custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public CustomerAddressFilter? Address { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
