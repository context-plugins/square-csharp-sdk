using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Request payload for the <see href="api-endpoint:Bookings-BulkRetrieveTeamMemberBookingProfiles">BulkRetrieveTeamMemberBookingProfiles</see> endpoint.
/// </summary>
public record BulkRetrieveTeamMemberBookingProfilesRequest
{
    /// <summary>
    /// A non-empty list of IDs of team members whose booking profiles you want to retrieve.
    /// </summary>
    [JsonPropertyName("team_member_ids")]
    public required IReadOnlyList<string> TeamMemberIds { get; init; }
}
