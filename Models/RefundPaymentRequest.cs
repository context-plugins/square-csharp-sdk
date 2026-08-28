using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Describes a request to refund a payment using <see href="api-endpoint:Refunds-RefundPayment">RefundPayment</see>.
/// </summary>
public record RefundPaymentRequest
{
    /// <summary>
    /// A unique string that identifies this <c>RefundPayment</c> request. The key can be any valid string
    /// but must be unique for every <c>RefundPayment</c> request.
    /// <para>
    /// Keys are limited to a max of 45 characters - however, the number of allowed characters might be
    /// less than 45, if multi-byte characters are used.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

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

    /// <summary>
    /// The unique ID of the payment being refunded.
    /// Required when unlinked=false, otherwise must not be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The ID indicating where funds will be refunded to. Required for unlinked refunds. For more
    /// information, see <see href="https://developer.squareup.com/docs/refunds-api/unlinked-refunds">Process an Unlinked Refund</see>.
    /// <para>
    /// For refunds linked to Square payments, <c>destination_id</c> is usually omitted; in this case, funds
    /// will be returned to the original payment source. The field may be specified in order to request
    /// a cross-method refund to a gift card. For more information,
    /// see <see href="https://developer.squareup.com/docs/payments-api/refund-payments#cross-method-refunds-to-gift-cards">Cross-method refunds to gift cards</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination_id")]
    public string? DestinationId { get; init; }

    /// <summary>
    /// Indicates that the refund is not linked to a Square payment.
    /// If set to true, <c>destination_id</c> and <c>location_id</c> must be supplied while <c>payment_id</c> must not
    /// be provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unlinked")]
    public bool? Unlinked { get; init; }

    /// <summary>
    /// The location ID associated with the unlinked refund.
    /// Required for requests specifying <c>unlinked=true</c>.
    /// Otherwise, if included when <c>unlinked=false</c>, will throw an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(50)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The <see href="entity:Customer">Customer</see> ID of the customer associated with the refund.
    /// This is required if the <c>destination_id</c> refers to a card on file created using the Cards
    /// API. Only allowed when <c>unlinked=true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// A description of the reason for the refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(192)]
    public string? Reason { get; init; }

    /// <summary>
    /// Used for optimistic concurrency. This opaque token identifies the current <c>Payment</c>
    /// version that the caller expects. If the server has a different version of the Payment,
    /// the update fails and a response with a VERSION_MISMATCH error is returned.
    /// If the versions match, or the field is not provided, the refund proceeds as normal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_version_token")]
    public string? PaymentVersionToken { get; init; }

    /// <summary>
    /// An optional <see href="entity:TeamMember">TeamMember</see> ID to associate with this refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [MaxLength(192)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// Stores details about a cash refund. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_details")]
    public DestinationDetailsCashRefundDetails? CashDetails { get; init; }

    /// <summary>
    /// Stores details about an external refund. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_details")]
    public DestinationDetailsExternalRefundDetails? ExternalDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
