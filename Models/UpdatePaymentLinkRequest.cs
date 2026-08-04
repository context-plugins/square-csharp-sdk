using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdatePaymentLinkRequest
{
    [JsonPropertyName("payment_link")]
    public required PaymentLink PaymentLink { get; init; }
}
