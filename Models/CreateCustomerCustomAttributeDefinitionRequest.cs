using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:CustomerCustomAttributes-CreateCustomerCustomAttributeDefinition">CreateCustomerCustomAttributeDefinition</see> request.
/// </summary>
public record CreateCustomerCustomAttributeDefinitionRequest
{
    /// <summary>
    /// Represents a definition for custom attribute values. A custom attribute definition
    /// specifies the key, visibility, schema, and other properties for a custom attribute.
    /// </summary>
    [JsonPropertyName("custom_attribute_definition")]
    public required CustomAttributeDefinition CustomAttributeDefinition { get; init; }

    /// <summary>
    /// A unique identifier for this request, used to ensure idempotency. For more information,
    /// see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(45)]
    public string? IdempotencyKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
