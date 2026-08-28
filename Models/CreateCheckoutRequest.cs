using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the parameters that can be included in the body of
/// a request to the <c>CreateCheckout</c> endpoint.
/// </summary>
public record CreateCheckoutRequest
{
    /// <summary>
    /// A unique string that identifies this checkout among others you have created. It can be
    /// any valid string but must be unique for every order sent to Square Checkout for a given location ID.
    /// <para>
    /// The idempotency key is used to avoid processing the same order more than once. If you are
    /// unsure whether a particular checkout was created successfully, you can attempt it again with
    /// the same idempotency key and all the same other parameters without worrying about creating duplicates.
    /// </para>
    /// <para>
    /// You should use a random number/string generator native to the language
    /// you are working in to generate strings for your idempotency keys.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(192, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    [JsonPropertyName("order")]
    public required CreateOrderRequest Order { get; init; }

    /// <summary>
    /// If <c>true</c>, Square Checkout collects shipping information on your behalf and stores
    /// that information with the transaction information in the Square Seller Dashboard.
    /// <para>
    /// Default: <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ask_for_shipping_address")]
    public bool? AskForShippingAddress { get; init; }

    /// <summary>
    /// The email address to display on the Square Checkout confirmation page
    /// and confirmation email that the buyer can use to contact the seller.
    /// <para>
    /// If this value is not set, the confirmation page and email display the
    /// primary email address associated with the seller's Square account.
    /// </para>
    /// <para>
    /// Default: none; only exists if explicitly set.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_support_email")]
    [MaxLength(254)]
    public string? MerchantSupportEmail { get; init; }

    /// <summary>
    /// If provided, the buyer's email is prepopulated on the checkout page
    /// as an editable text field.
    /// <para>
    /// Default: none; only exists if explicitly set.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_populate_buyer_email")]
    [MaxLength(254)]
    public string? PrePopulateBuyerEmail { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_populate_shipping_address")]
    public Address? PrePopulateShippingAddress { get; init; }

    /// <summary>
    /// The URL to redirect to after the checkout is completed with <c>checkoutId</c>,
    /// <c>transactionId</c>, and <c>referenceId</c> appended as URL parameters. For example,
    /// if the provided redirect URL is <c>http://www.example.com/order-complete</c>, a
    /// successful transaction redirects the customer to:
    /// <para>
    /// <c>http://www.example.com/order-complete?checkoutId=xxxxxx&amp;amp;referenceId=xxxxxx&amp;amp;transactionId=xxxxxx</c>
    /// </para>
    /// <para>
    /// If you do not provide a redirect URL, Square Checkout displays an order
    /// confirmation page on your behalf; however, it is strongly recommended that
    /// you provide a redirect URL so you can verify the transaction results and
    /// finalize the order through your existing/normal confirmation workflow.
    /// </para>
    /// <para>
    /// Default: none; only exists if explicitly set.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_url")]
    [MaxLength(800)]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The basic primitive of a multi-party transaction. The value is optional.
    /// The transaction facilitated by you can be split from here.
    /// <para>
    /// If you provide this value, the <c>amount_money</c> value in your <c>additional_recipients</c> field
    /// cannot be more than 90% of the <c>total_money</c> calculated by Square for your order.
    /// The <c>location_id</c> must be a valid seller location where the checkout is occurring.
    /// </para>
    /// <para>
    /// This field requires <c>PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS</c> OAuth permission.
    /// </para>
    /// <para>
    /// This field is currently not supported in the Square Sandbox.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additional_recipients")]
    public IReadOnlyList<ChargeRequestAdditionalRecipient>? AdditionalRecipients { get; init; }

    /// <summary>
    /// An optional note to associate with the <c>checkout</c> object.
    /// <para>
    /// This value cannot exceed 60 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(60)]
    public string? Note { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
