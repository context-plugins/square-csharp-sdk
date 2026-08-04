using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents one upsert within the bulk operation.
/// </summary>
public record BulkUpsertOrderCustomAttributesRequestUpsertCustomAttribute
{
    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonPropertyName("custom_attribute")]
    public required CustomAttribute CustomAttribute { get; init; }

    /// <summary>
    /// A unique identifier for this request, used to ensure idempotency.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the target <see href="entity:Order">order</see>.
    /// </summary>
    [JsonPropertyName("order_id")]
    [StringLength(255, MinimumLength = 1)]
    public required string OrderId { get; init; }
}
