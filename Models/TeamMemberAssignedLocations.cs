using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// An object that represents a team member's assignment to locations.
/// </summary>
public record TeamMemberAssignedLocations
{
    /// <summary>
    /// Enumerates the possible assignment types that the team member can have.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment_type")]
    public TeamMemberAssignedLocationsAssignmentType? AssignmentType { get; init; }

    /// <summary>
    /// The explicit locations that the team member is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string?>? LocationIds { get; init; }
}
