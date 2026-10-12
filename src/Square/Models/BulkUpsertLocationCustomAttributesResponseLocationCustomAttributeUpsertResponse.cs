using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a response for an individual upsert request in a <see href="api-endpoint:LocationCustomAttributes-BulkUpsertLocationCustomAttributes">BulkUpsertLocationCustomAttributes</see> operation.
/// </summary>
public record BulkUpsertLocationCustomAttributesResponseLocationCustomAttributeUpsertResponse
{
    /// <summary>
    /// The ID of the location associated with the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute")]
    public CustomAttribute? CustomAttribute { get; init; }

    /// <summary>
    /// Any errors that occurred while processing the individual request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
