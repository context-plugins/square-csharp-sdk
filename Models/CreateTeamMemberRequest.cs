using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a create request for a <c>TeamMember</c> object.
/// </summary>
public record CreateTeamMemberRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateTeamMember</c> request.
    /// Keys can be any valid string, but must be unique for every request.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// <para>
    /// The minimum length is 1 and the maximum length is 45.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// A record representing an individual team member for a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member")]
    public TeamMember? TeamMember { get; init; }
}
