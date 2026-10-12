using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// One or more PayoutEntries that make up a Payout. Each one has a date, amount, and type of activity.
/// The total amount of the payout will equal the sum of the payout entries for a batch payout
/// </summary>
public record PayoutEntry
{
    /// <summary>
    /// A unique ID for the payout entry.
    /// </summary>
    [JsonPropertyName("id")]
    [MinLength(1)]
    public required string Id { get; init; }

    /// <summary>
    /// The ID of the payout entries’ associated payout.
    /// </summary>
    [JsonPropertyName("payout_id")]
    [MinLength(1)]
    public required string PayoutId { get; init; }

    /// <summary>
    /// The timestamp of when the payout entry affected the balance, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effective_at")]
    public string? EffectiveAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public ActivityType? Type { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_amount_money")]
    public Money? GrossAmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee_amount_money")]
    public Money? FeeAmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_amount_money")]
    public Money? NetAmountMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_app_fee_revenue_details")]
    public PaymentBalanceActivityAppFeeRevenueDetail? TypeAppFeeRevenueDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_app_fee_refund_details")]
    public PaymentBalanceActivityAppFeeRefundDetail? TypeAppFeeRefundDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_automatic_savings_details")]
    public PaymentBalanceActivityAutomaticSavingsDetail? TypeAutomaticSavingsDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_automatic_savings_reversed_details")]
    public PaymentBalanceActivityAutomaticSavingsReversedDetail? TypeAutomaticSavingsReversedDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_charge_details")]
    public PaymentBalanceActivityChargeDetail? TypeChargeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_deposit_fee_details")]
    public PaymentBalanceActivityDepositFeeDetail? TypeDepositFeeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_deposit_fee_reversed_details")]
    public PaymentBalanceActivityDepositFeeReversedDetail? TypeDepositFeeReversedDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_dispute_details")]
    public PaymentBalanceActivityDisputeDetail? TypeDisputeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_fee_details")]
    public PaymentBalanceActivityFeeDetail? TypeFeeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_free_processing_details")]
    public PaymentBalanceActivityFreeProcessingDetail? TypeFreeProcessingDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_hold_adjustment_details")]
    public PaymentBalanceActivityHoldAdjustmentDetail? TypeHoldAdjustmentDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_open_dispute_details")]
    public PaymentBalanceActivityOpenDisputeDetail? TypeOpenDisputeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_other_details")]
    public PaymentBalanceActivityOtherDetail? TypeOtherDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_other_adjustment_details")]
    public PaymentBalanceActivityOtherAdjustmentDetail? TypeOtherAdjustmentDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_refund_details")]
    public PaymentBalanceActivityRefundDetail? TypeRefundDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_release_adjustment_details")]
    public PaymentBalanceActivityReleaseAdjustmentDetail? TypeReleaseAdjustmentDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_reserve_hold_details")]
    public PaymentBalanceActivityReserveHoldDetail? TypeReserveHoldDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_reserve_release_details")]
    public PaymentBalanceActivityReserveReleaseDetail? TypeReserveReleaseDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_square_capital_payment_details")]
    public PaymentBalanceActivitySquareCapitalPaymentDetail? TypeSquareCapitalPaymentDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_square_capital_reversed_payment_details")]
    public PaymentBalanceActivitySquareCapitalReversedPaymentDetail? TypeSquareCapitalReversedPaymentDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_tax_on_fee_details")]
    public PaymentBalanceActivityTaxOnFeeDetail? TypeTaxOnFeeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_third_party_fee_details")]
    public PaymentBalanceActivityThirdPartyFeeDetail? TypeThirdPartyFeeDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_third_party_fee_refund_details")]
    public PaymentBalanceActivityThirdPartyFeeRefundDetail? TypeThirdPartyFeeRefundDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_square_payroll_transfer_details")]
    public PaymentBalanceActivitySquarePayrollTransferDetail? TypeSquarePayrollTransferDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_square_payroll_transfer_reversed_details")]
    public PaymentBalanceActivitySquarePayrollTransferReversedDetail? TypeSquarePayrollTransferReversedDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
