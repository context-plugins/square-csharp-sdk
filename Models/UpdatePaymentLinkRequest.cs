using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record UpdatePaymentLinkRequest
{
    [JsonPropertyName("payment_link")]
    public required PaymentLink PaymentLink { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
