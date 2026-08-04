using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an individual delete request in a <see href="api-endpoint:MerchantCustomAttributes-BulkDeleteMerchantCustomAttributes">BulkDeleteMerchantCustomAttributes</see>
/// request. An individual request contains an optional ID of the associated custom attribute definition
/// and optional key of the associated custom attribute definition.
/// </summary>
public record BulkDeleteMerchantCustomAttributesRequestMerchantCustomAttributeDeleteRequest
{
    /// <summary>
    /// The key of the associated custom attribute definition.
    /// Represented as a qualified key if the requesting app is not the definition owner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [RegularExpression("^([a-zA-Z0-9_-]+:)?[a-zA-Z0-9_-]{1,60}$")]
    public string? Key { get; init; }
}
