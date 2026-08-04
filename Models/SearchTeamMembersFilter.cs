using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a filter used in a search for <c>TeamMember</c> objects. <c>AND</c> logic is applied
/// between the individual fields, and <c>OR</c> logic is applied within list-based fields.
/// For example, setting this filter value:
/// <code>
/// filter = (locations_ids = ["A", "B"], status = ACTIVE)
/// </code>
/// returns only active team members assigned to either location "A" or "B".
/// </summary>
public record SearchTeamMembersFilter
{
    /// <summary>
    /// When present, filters by team members assigned to the specified locations.
    /// When empty, includes team members assigned to any location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string?>? LocationIds { get; init; }

    /// <summary>
    /// Enumerates the possible statuses the team member can have within a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TeamMemberStatus? Status { get; init; }

    /// <summary>
    /// When present and set to true, returns the team member who is the owner of the Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; init; }
}
