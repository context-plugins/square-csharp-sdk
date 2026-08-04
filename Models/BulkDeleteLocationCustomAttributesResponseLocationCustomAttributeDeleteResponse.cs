using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an individual delete response in a <see href="api-endpoint:LocationCustomAttributes-BulkDeleteLocationCustomAttributes">BulkDeleteLocationCustomAttributes</see>
/// request.
/// </summary>
public record BulkDeleteLocationCustomAttributesResponseLocationCustomAttributeDeleteResponse
{
    /// <summary>
    /// The ID of the location associated with the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Errors that occurred while processing the individual LocationCustomAttributeDeleteRequest request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
