using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:MerchantCustomAttributes-DeleteMerchantCustomAttribute">DeleteMerchantCustomAttribute</see> response.
/// Either an empty object <c>{}</c> (for a successful deletion) or <c>errors</c> is present in the response.
/// </summary>
public record DeleteMerchantCustomAttributeResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
