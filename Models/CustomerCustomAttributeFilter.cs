using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The custom attribute filter. Use this filter in a set of <see href="entity:CustomerCustomAttributeFilters">custom attribute filters</see> to search
/// based on the value or last updated date of a customer-related <see href="entity:CustomAttribute">custom attribute</see>.
/// </summary>
public record CustomerCustomAttributeFilter
{
    /// <summary>
    /// The <c>key</c> of the <see href="entity:CustomAttribute">custom attribute</see> to filter by. The key is the identifier of the custom attribute
    /// (and the corresponding custom attribute definition) and can be retrieved using the <see href="api:CustomerCustomAttributes">Customer Custom Attributes API</see>.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// A type-specific filter used in a <see href="entity:CustomerCustomAttributeFilter">custom attribute filter</see> to search based on the value
    /// of a customer-related <see href="entity:CustomAttribute">custom attribute</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public CustomerCustomAttributeFilterValue? Filter { get; init; }

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
}
