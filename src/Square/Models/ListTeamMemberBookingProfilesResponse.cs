using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record ListTeamMemberBookingProfilesResponse
{
    /// <summary>
    /// The list of team member booking profiles. The results are returned in the ascending order of the time
    /// when the team member booking profiles were last updated. Multiple booking profiles updated at the same time
    /// are further sorted in the ascending order of their IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_booking_profiles")]
    public IReadOnlyList<TeamMemberBookingProfile>? TeamMemberBookingProfiles { get; init; }

    /// <summary>
    /// The pagination cursor to be used in the subsequent request to get the next page of the results. Stop retrieving the next page of the results when the cursor is not set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(65536)]
    public string? Cursor { get; init; }

    /// <summary>
    /// Errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
