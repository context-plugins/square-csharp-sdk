using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the possible assignment types that the team member can have.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TeamMemberAssignedLocationsAssignmentType>))]
public sealed record TeamMemberAssignedLocationsAssignmentType : OpenStringEnum<TeamMemberAssignedLocationsAssignmentType>
{
    private TeamMemberAssignedLocationsAssignmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// The team member is assigned to all current and future locations. The <c>location_ids</c> field
    /// is empty if the team member has this assignment type.
    /// </summary>
    public static readonly TeamMemberAssignedLocationsAssignmentType AllCurrentAndFutureLocations = new(
        "ALL_CURRENT_AND_FUTURE_LOCATIONS");

    /// <summary>
    /// The team member is assigned to an explicit subset of locations. The <c>location_ids</c> field
    /// is the list of locations that the team member is assigned to.
    /// </summary>
    public static readonly TeamMemberAssignedLocationsAssignmentType ExplicitLocations = new("EXPLICIT_LOCATIONS");

    public TResult Match<TResult>(Func<TResult> onAllCurrentAndFutureLocations,
        Func<TResult> onExplicitLocations,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AllCurrentAndFutureLocations => onAllCurrentAndFutureLocations(),
            _ when this == ExplicitLocations => onExplicitLocations(),
            _ => otherwise(Value)
        };

    public void Match(Action onAllCurrentAndFutureLocations, Action onExplicitLocations, Action<string> otherwise)
    {
        if (this == AllCurrentAndFutureLocations) onAllCurrentAndFutureLocations();
        else if (this == ExplicitLocations) onExplicitLocations();
        else otherwise(Value);
    }
}
