using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes a request to cancel a payment using
/// <see href="api-endpoint:Payments-CancelPaymentByIdempotencyKey">CancelPaymentByIdempotencyKey</see>.
/// </summary>
public record CancelPaymentByIdempotencyKeyRequest
{
    /// <summary>
    /// The <c>idempotency_key</c> identifying the payment to be canceled.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
