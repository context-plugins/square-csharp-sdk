using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TeamMemberWageSettingUpdatedEventObject
{
    /// <summary>
    /// Represents information about the overtime exemption status, job assignments, and compensation
    /// for a <see href="entity:TeamMember">team member</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage_setting")]
    public WageSetting? WageSetting { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
