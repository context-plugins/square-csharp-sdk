using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:LocationCustomAttributes-BulkDeleteLocationCustomAttributes">BulkDeleteLocationCustomAttributes</see> request.
/// </summary>
public record BulkDeleteLocationCustomAttributesRequest
{
    /// <summary>
    /// The data used to update the <c>CustomAttribute</c> objects.
    /// The keys must be unique and are used to map to the corresponding response.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkDeleteLocationCustomAttributesRequestLocationCustomAttributeDeleteRequest> Values { get; init; }
}
