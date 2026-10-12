using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Details about the customer making the payment.
/// </summary>
public record CustomerDetails
{
    /// <summary>
    /// Indicates whether the customer initiated the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_initiated")]
    public bool? CustomerInitiated { get; init; }

    /// <summary>
    /// Indicates that the seller keyed in payment details on behalf of the customer.
    /// This is used to flag a payment as Mail Order / Telephone Order (MOTO).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seller_keyed_in")]
    public bool? SellerKeyedIn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
