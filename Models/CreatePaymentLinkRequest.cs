using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CreatePaymentLinkRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreatePaymentLinkRequest</c> request.
    /// If you do not provide a unique string (or provide an empty string as the value),
    /// the endpoint treats each request as independent.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(192)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// A description of the payment link. You provide this optional description that is useful in your
    /// application context. It is not used anywhere.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(4096)]
    public string? Description { get; init; }

    /// <summary>
    /// Describes an ad hoc item and price to generate a quick pay checkout link.
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/checkout-api/quick-pay-checkout">Quick Pay Checkout</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quick_pay")]
    public QuickPay? QuickPay { get; init; }

    /// <summary>
    /// Contains all information related to a single order to process with Square,
    /// including line items that specify the products to purchase. <c>Order</c> objects also
    /// include information about any associated tenders, refunds, and returns.
    /// <para>
    /// All Connect V2 Transactions have all been converted to Orders including all associated
    /// itemization data.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public Order? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout_options")]
    public CheckoutOptions? CheckoutOptions { get; init; }

    /// <summary>
    /// Describes buyer data to prepopulate in the payment form.
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/checkout-api/optional-checkout-configurations">Optional Checkout Configurations</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_populated_data")]
    public PrePopulatedData? PrePopulatedData { get; init; }

    /// <summary>
    /// A note for the payment. After processing the payment, Square adds this note to the resulting <c>Payment</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_note")]
    [MaxLength(500)]
    public string? PaymentNote { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
