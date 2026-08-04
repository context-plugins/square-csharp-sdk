using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an individual upsert request in a <see href="api-endpoint:MerchantCustomAttributes-BulkUpsertMerchantCustomAttributes">BulkUpsertMerchantCustomAttributes</see>
/// request. An individual request contains a merchant ID, the custom attribute to create or update,
/// and an optional idempotency key.
/// </summary>
public record BulkUpsertMerchantCustomAttributesRequestMerchantCustomAttributeUpsertRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Merchant">merchant</see>.
    /// </summary>
    [JsonPropertyName("merchant_id")]
    [MinLength(1)]
    public required string MerchantId { get; init; }

    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonPropertyName("custom_attribute")]
    public required CustomAttribute CustomAttribute { get; init; }

    /// <summary>
    /// A unique identifier for this individual upsert request, used to ensure idempotency.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }
}
