using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an upsert request for an order custom attribute.
/// </summary>
public record UpsertOrderCustomAttributeRequest
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
