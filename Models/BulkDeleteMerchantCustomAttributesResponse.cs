using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:MerchantCustomAttributes-BulkDeleteMerchantCustomAttributes">BulkDeleteMerchantCustomAttributes</see> response,
/// which contains a map of responses that each corresponds to an individual delete request.
/// </summary>
public record BulkDeleteMerchantCustomAttributesResponse
{
    /// <summary>
    /// A map of responses that correspond to individual delete requests. Each response has the
    /// same key as the corresponding request.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkDeleteMerchantCustomAttributesResponseMerchantCustomAttributeDeleteResponse> Values { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
