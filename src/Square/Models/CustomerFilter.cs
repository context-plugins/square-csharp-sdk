using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the filtering criteria in a <see href="entity:CustomerQuery">search query</see> that defines how to filter
/// customer profiles returned in <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see> results.
/// </summary>
public record CustomerFilter
{
    /// <summary>
    /// The creation source filter.
    /// <para>
    /// If one or more creation sources are set, customer profiles are included in,
    /// or excluded from, the result if they match at least one of the filter criteria.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creation_source")]
    public CustomerCreationSourceFilter? CreationSource { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public TimeRange? CreatedAt { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public TimeRange? UpdatedAt { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public CustomerTextFilter? EmailAddress { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public CustomerTextFilter? PhoneNumber { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public CustomerTextFilter? ReferenceId { get; init; }

    /// <summary>
    /// A filter to select resources based on an exact field value. For any given
    /// value, the value can only be in one property. Depending on the field, either
    /// all properties can be set or only a subset will be available.
    /// <para>
    /// Refer to the documentation of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_ids")]
    public FilterValue? GroupIds { get; init; }

    /// <summary>
    /// The custom attribute filters in a set of <see href="entity:CustomerFilter">customer filters</see> used in a search query. Use this filter
    /// to search based on <see href="entity:CustomAttribute">custom attributes</see> that are assigned to customer profiles. For more information, see
    /// <see href="https://developer.squareup.com/docs/customers-api/use-the-api/search-customers#search-by-custom-attribute">Search by custom attribute</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute")]
    public CustomerCustomAttributeFilters? CustomAttribute { get; init; }

    /// <summary>
    /// A filter to select resources based on an exact field value. For any given
    /// value, the value can only be in one property. Depending on the field, either
    /// all properties can be set or only a subset will be available.
    /// <para>
    /// Refer to the documentation of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment_ids")]
    public FilterValue? SegmentIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
