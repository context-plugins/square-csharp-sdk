using System.Text.Json.Serialization;

namespace Square.Models;

public record TeamMemberCreatedEventObject
{
    /// <summary>
    /// A record representing an individual team member for a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member")]
    public TeamMember? TeamMember { get; init; }
}
