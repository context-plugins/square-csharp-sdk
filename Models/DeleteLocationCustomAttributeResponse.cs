using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:LocationCustomAttributes-DeleteLocationCustomAttribute">DeleteLocationCustomAttribute</see> response.
/// Either an empty object <c>{}</c> (for a successful deletion) or <c>errors</c> is present in the response.
/// </summary>
public record DeleteLocationCustomAttributeResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
