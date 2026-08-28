using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a response from a bulk upsert of order custom attributes.
/// </summary>
public record BulkUpsertOrderCustomAttributesResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A map of responses that correspond to individual upsert operations for custom attributes.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, UpsertOrderCustomAttributeResponse> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
