using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CheckoutOptions
{
    /// <summary>
    /// Indicates whether the payment allows tipping.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_tipping")]
    public bool? AllowTipping { get; init; }

    /// <summary>
    /// The custom fields requesting information from the buyer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<CustomField>? CustomFields { get; init; }

    /// <summary>
    /// The ID of the subscription plan for the buyer to pay and subscribe.
    /// For more information, see <see href="https://developer.squareup.com/docs/checkout-api/subscription-plan-checkout">Subscription Plan Checkout</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_id")]
    [MaxLength(255)]
    public string? SubscriptionPlanId { get; init; }

    /// <summary>
    /// The confirmation page URL to redirect the buyer to after Square processes the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_url")]
    [MaxLength(2048)]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The email address that buyers can use to contact the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_support_email")]
    [MaxLength(256)]
    public string? MerchantSupportEmail { get; init; }

    /// <summary>
    /// Indicates whether to include the address fields in the payment form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ask_for_shipping_address")]
    public bool? AskForShippingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_payment_methods")]
    public AcceptedPaymentMethods? AcceptedPaymentMethods { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_fee_money")]
    public Money? AppFeeMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_fee")]
    public ShippingFee? ShippingFee { get; init; }

    /// <summary>
    /// Indicates whether to include the <c>Add coupon</c> section for the buyer to provide a Square marketing coupon in the payment form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enable_coupon")]
    public bool? EnableCoupon { get; init; }

    /// <summary>
    /// Indicates whether to include the <c>REWARDS</c> section for the buyer to opt in to loyalty, redeem rewards in the payment form, or both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enable_loyalty")]
    public bool? EnableLoyalty { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
