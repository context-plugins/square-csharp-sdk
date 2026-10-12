using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Request to update a transfer order
/// </summary>
public record UpdateTransferOrderRequest
{
    /// <summary>
    /// A unique string that identifies this UpdateTransferOrder request. Keys must contain only alphanumeric characters, dashes and underscores
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Data model for updating a transfer order. All fields are optional.
    /// </summary>
    [JsonPropertyName("transfer_order")]
    public required UpdateTransferOrderData TransferOrder { get; init; }

    /// <summary>
    /// Version for optimistic concurrency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
