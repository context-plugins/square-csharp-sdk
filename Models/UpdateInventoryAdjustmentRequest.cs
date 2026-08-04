using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateInventoryAdjustmentRequest
{
    /// <summary>
    /// A client-supplied, universally unique identifier (UUID) for the
    /// request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see> in the
    /// <see href="https://developer.squareup.com/docs/buildbasics">Build Basics</see> section for more
    /// information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a change in state or quantity of product inventory at a
    /// particular time and location.
    /// </summary>
    [JsonPropertyName("adjustment")]
    public required InventoryAdjustment Adjustment { get; init; }
}
