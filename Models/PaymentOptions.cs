using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record PaymentOptions
{
    /// <summary>
    /// Indicates whether the <c>Payment</c> objects created from this <c>TerminalCheckout</c> are
    /// automatically <c>COMPLETED</c> or left in an <c>APPROVED</c> state for later modification.
    /// <para>
    /// Default: true
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autocomplete")]
    public bool? Autocomplete { get; init; }

    /// <summary>
    /// The duration of time after the payment's creation when Square automatically resolves the
    /// payment. This automatic resolution applies only to payments that do not reach a terminal state
    /// (<c>COMPLETED</c> or <c>CANCELED</c>) before the <c>delay_duration</c> time period.
    /// <para>
    /// This parameter should be specified as a time duration, in RFC 3339 format, with a minimum value
    /// of 1 minute and a maximum value of 36 hours. This feature is only supported for card payments,
    /// and all payments will be considered card-present.
    /// </para>
    /// <para>
    /// This parameter can only be set for a delayed capture payment (<c>autocomplete=false</c>). For more
    /// information, see <see href="https://developer.squareup.com/docs/payments-api/take-payments/card-payments/delayed-capture#time-threshold">Delayed Capture</see>.
    /// </para>
    /// <para>
    /// Default: "PT36H" (36 hours) from the creation time
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_duration")]
    public string? DelayDuration { get; init; }

    /// <summary>
    /// If set to <c>true</c> and charging a Square Gift Card, a payment might be returned with
    /// <c>amount_money</c> equal to less than what was requested. For example, a request for $20 when charging
    /// a Square Gift Card with a balance of $5 results in an APPROVED payment of $5. You might choose
    /// to prompt the buyer for an additional payment to cover the remainder or cancel the Gift Card
    /// payment.
    /// <para>
    /// This parameter can only be set for a delayed capture payment (<c>autocomplete=false</c>).
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/payments-api/take-payments/card-payments/partial-payments-with-gift-cards">Take Partial Payments</see>.
    /// </para>
    /// <para>
    /// Default: false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accept_partial_authorization")]
    public bool? AcceptPartialAuthorization { get; init; }

    /// <summary>
    /// Describes the action to be applied to a delayed capture payment when the delay_duration
    /// has elapsed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_action")]
    public PaymentOptionsDelayAction? DelayAction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
