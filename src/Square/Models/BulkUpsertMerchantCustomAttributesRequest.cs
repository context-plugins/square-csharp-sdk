using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:MerchantCustomAttributes-BulkUpsertMerchantCustomAttributes">BulkUpsertMerchantCustomAttributes</see> request.
/// </summary>
public record BulkUpsertMerchantCustomAttributesRequest
{
    /// <summary>
    /// A map containing 1 to 25 individual upsert requests. For each request, provide an
    /// arbitrary ID that is unique for this <c>BulkUpsertMerchantCustomAttributes</c> request and the
    /// information needed to create or update a custom attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BulkUpsertMerchantCustomAttributesRequestMerchantCustomAttributeUpsertRequest> Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
