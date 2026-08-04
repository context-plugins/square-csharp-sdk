using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a bulk delete request for one or more order custom attributes.
/// </summary>
public record BulkDeleteOrderCustomAttributesRequest
{
    /// <summary>
    /// A map of requests that correspond to individual delete operations for custom attributes.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkDeleteOrderCustomAttributesRequestDeleteCustomAttribute> Values { get; init; }
}
