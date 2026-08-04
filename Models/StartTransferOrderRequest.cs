using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Request to start a transfer order, changing its status from DRAFT to STARTED.
/// </summary>
public record StartTransferOrderRequest
{
    /// <summary>
    /// A unique string that identifies this UpdateTransferOrder request. Keys can be
    /// any valid string but must be unique for every UpdateTransferOrder request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Version for optimistic concurrency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }
}
