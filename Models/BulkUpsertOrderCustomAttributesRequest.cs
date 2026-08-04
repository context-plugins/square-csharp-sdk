using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a bulk upsert request for one or more order custom attributes.
/// </summary>
public record BulkUpsertOrderCustomAttributesRequest
{
    /// <summary>
    /// A map of requests that correspond to individual upsert operations for custom attributes.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkUpsertOrderCustomAttributesRequestUpsertCustomAttribute> Values { get; init; }
}
