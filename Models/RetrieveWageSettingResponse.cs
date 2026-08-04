using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a response from a retrieve request containing the specified <c>WageSetting</c> object or error messages.
/// </summary>
public record RetrieveWageSettingResponse
{
    /// <summary>
    /// Represents information about the overtime exemption status, job assignments, and compensation
    /// for a <see href="entity:TeamMember">team member</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage_setting")]
    public WageSetting? WageSetting { get; init; }

    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
