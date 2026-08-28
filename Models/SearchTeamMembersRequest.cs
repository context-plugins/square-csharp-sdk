using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Represents a search request for a filtered list of <c>TeamMember</c> objects.
/// </summary>
public record SearchTeamMembersRequest
{
    /// <summary>
    /// Represents the parameters in a search for <c>TeamMember</c> objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchTeamMembersQuery? Query { get; init; }

    /// <summary>
    /// The maximum number of <c>TeamMember</c> objects in a page (100 by default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }

    /// <summary>
    /// The opaque cursor for fetching the next page. For more information, see
    /// <see href="https://developer.squareup.com/docs/working-with-apis/pagination">pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
