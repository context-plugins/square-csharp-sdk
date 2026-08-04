using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The creation source filter.
/// <para>
/// If one or more creation sources are set, customer profiles are included in,
/// or excluded from, the result if they match at least one of the filter criteria.
/// </para>
/// </summary>
public record CustomerCreationSourceFilter
{
    /// <summary>
    /// The list of creation sources used as filtering criteria.
    /// See <see href="#type-customercreationsource">CustomerCreationSource</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<CustomerCreationSource?>? Values { get; init; }

    /// <summary>
    /// Indicates whether customers should be included in, or excluded from,
    /// the result set when they match the filtering criteria.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rule")]
    public CustomerInclusionExclusion? Rule { get; init; }
}
