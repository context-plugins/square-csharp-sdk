using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A request to unlink a customer from a gift card.
/// </summary>
public record UnlinkCustomerFromGiftCardRequest
{
    /// <summary>
    /// The ID of the customer to unlink from the gift card.
    /// </summary>
    [JsonPropertyName("customer_id")]
    [StringLength(191, MinimumLength = 1)]
    public required string CustomerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
