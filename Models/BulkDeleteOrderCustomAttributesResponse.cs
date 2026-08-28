using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a response from deleting one or more order custom attributes.
/// </summary>
public record BulkDeleteOrderCustomAttributesResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A map of responses that correspond to individual delete requests. Each response has the same ID
    /// as the corresponding request and contains either a <c>custom_attribute</c> or an <c>errors</c> field.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, DeleteOrderCustomAttributeResponse> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
