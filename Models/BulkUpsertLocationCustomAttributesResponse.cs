using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:LocationCustomAttributes-BulkUpsertLocationCustomAttributes">BulkUpsertLocationCustomAttributes</see> response,
/// which contains a map of responses that each corresponds to an individual upsert request.
/// </summary>
public record BulkUpsertLocationCustomAttributesResponse
{
    /// <summary>
    /// A map of responses that correspond to individual upsert requests. Each response has the
    /// same ID as the corresponding request and contains either a <c>location_id</c> and <c>custom_attribute</c> or an <c>errors</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyDictionary<string, BulkUpsertLocationCustomAttributesResponseLocationCustomAttributeUpsertResponse>? Values { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
