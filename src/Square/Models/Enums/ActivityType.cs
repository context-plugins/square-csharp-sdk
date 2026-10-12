using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ActivityType>))]
public sealed record ActivityType : OpenStringEnum<ActivityType>
{
    private ActivityType(string value) : base(value)
    {
    }

    /// <summary>
    /// A manual adjustment applied to the seller's account by Square.
    /// </summary>
    public static readonly ActivityType Adjustment = new("ADJUSTMENT");

    /// <summary>
    /// A refund for an application fee on a payment.
    /// </summary>
    public static readonly ActivityType AppFeeRefund = new("APP_FEE_REFUND");

    /// <summary>
    /// Revenue generated from an application fee on a payment.
    /// </summary>
    public static readonly ActivityType AppFeeRevenue = new("APP_FEE_REVENUE");

    /// <summary>
    /// An automatic transfer from the payment processing balance to the Square Savings account. These are generally proportional to the seller's sales.
    /// </summary>
    public static readonly ActivityType AutomaticSavings = new("AUTOMATIC_SAVINGS");

    /// <summary>
    /// An automatic transfer from the Square Savings account back to the processing balance. These are generally proportional to the seller's refunds.
    /// </summary>
    public static readonly ActivityType AutomaticSavingsReversed = new("AUTOMATIC_SAVINGS_REVERSED");

    /// <summary>
    /// A credit card payment capture.
    /// </summary>
    public static readonly ActivityType Charge = new("CHARGE");

    /// <summary>
    /// A fee assessed because of a deposit, such as an instant deposit.
    /// </summary>
    public static readonly ActivityType DepositFee = new("DEPOSIT_FEE");

    /// <summary>
    /// Indicates that Square returned a fee that was previously assessed because of a deposit, such as an instant deposit, back to the seller's account.
    /// </summary>
    public static readonly ActivityType DepositFeeReversed = new("DEPOSIT_FEE_REVERSED");

    /// <summary>
    /// The balance change due to a dispute event.
    /// </summary>
    public static readonly ActivityType Dispute = new("DISPUTE");

    /// <summary>
    /// An escheatment entry for remittance.
    /// </summary>
    public static readonly ActivityType Escheatment = new("ESCHEATMENT");

    /// <summary>
    /// The cost plus adjustment fee.
    /// </summary>
    public static readonly ActivityType Fee = new("FEE");

    /// <summary>
    /// Square offers free payments processing for a variety of business scenarios, including seller
    /// referrals or when Square wants to apologize (for example, for a bug, customer service, or repricing complication).
    /// This entry represents a credit to the seller for the purposes of free processing.
    /// </summary>
    public static readonly ActivityType FreeProcessing = new("FREE_PROCESSING");

    /// <summary>
    /// An adjustment made by Square related to holding a payment.
    /// </summary>
    public static readonly ActivityType HoldAdjustment = new("HOLD_ADJUSTMENT");

    /// <summary>
    /// An external change to a seller's balance (initial, in the sense that it causes the creation of the other activity types, such as a hold and refund).
    /// </summary>
    public static readonly ActivityType InitialBalanceChange = new("INITIAL_BALANCE_CHANGE");

    /// <summary>
    /// The balance change from a money transfer.
    /// </summary>
    public static readonly ActivityType MoneyTransfer = new("MONEY_TRANSFER");

    /// <summary>
    /// The reversal of a money transfer.
    /// </summary>
    public static readonly ActivityType MoneyTransferReversal = new("MONEY_TRANSFER_REVERSAL");

    /// <summary>
    /// The balance change for a chargeback that's been filed.
    /// </summary>
    public static readonly ActivityType OpenDispute = new("OPEN_DISPUTE");

    /// <summary>
    /// Any other type that doesn't belong in the rest of the types.
    /// </summary>
    public static readonly ActivityType Other = new("OTHER");

    /// <summary>
    /// Any other type of adjustment that doesn't fall under existing types.
    /// </summary>
    public static readonly ActivityType OtherAdjustment = new("OTHER_ADJUSTMENT");

    /// <summary>
    /// A fee paid to a third-party seller.
    /// </summary>
    public static readonly ActivityType PaidServiceFee = new("PAID_SERVICE_FEE");

    /// <summary>
    /// A fee refunded to a third-party seller.
    /// </summary>
    public static readonly ActivityType PaidServiceFeeRefund = new("PAID_SERVICE_FEE_REFUND");

    /// <summary>
    /// Repayment for a redemption code.
    /// </summary>
    public static readonly ActivityType RedemptionCode = new("REDEMPTION_CODE");

    /// <summary>
    /// A refund for an existing card payment.
    /// </summary>
    public static readonly ActivityType Refund = new("REFUND");

    /// <summary>
    /// An adjustment made by Square related to releasing a payment.
    /// </summary>
    public static readonly ActivityType ReleaseAdjustment = new("RELEASE_ADJUSTMENT");

    /// <summary>
    /// Fees paid for a funding risk reserve.
    /// </summary>
    public static readonly ActivityType ReserveHold = new("RESERVE_HOLD");

    /// <summary>
    /// Fees released from a risk reserve.
    /// </summary>
    public static readonly ActivityType ReserveRelease = new("RESERVE_RELEASE");

    /// <summary>
    /// An entry created when Square receives a response for the ACH file that Square sent indicating that the
    /// settlement of the original entry failed.
    /// </summary>
    public static readonly ActivityType ReturnedPayout = new("RETURNED_PAYOUT");

    /// <summary>
    /// A capital merchant cash advance (MCA) assessment. These are generally proportional to the merchant's sales but can be issued for other reasons related to the MCA.
    /// </summary>
    public static readonly ActivityType SquareCapitalPayment = new("SQUARE_CAPITAL_PAYMENT");

    /// <summary>
    /// A capital merchant cash advance (MCA) assessment refund. These are generally proportional to the merchant's refunds but can be issued for other reasons related to the MCA.
    /// </summary>
    public static readonly ActivityType SquareCapitalReversedPayment = new("SQUARE_CAPITAL_REVERSED_PAYMENT");

    /// <summary>
    /// A fee charged for subscription to a Square product.
    /// </summary>
    public static readonly ActivityType SubscriptionFee = new("SUBSCRIPTION_FEE");

    /// <summary>
    /// A Square subscription fee that's been refunded.
    /// </summary>
    public static readonly ActivityType SubscriptionFeePaidRefund = new("SUBSCRIPTION_FEE_PAID_REFUND");

    /// <summary>
    /// The refund of a previously charged Square product subscription fee.
    /// </summary>
    public static readonly ActivityType SubscriptionFeeRefund = new("SUBSCRIPTION_FEE_REFUND");

    /// <summary>
    /// The tax paid on fee amounts.
    /// </summary>
    public static readonly ActivityType TaxOnFee = new("TAX_ON_FEE");

    /// <summary>
    /// Fees collected by a third-party platform.
    /// </summary>
    public static readonly ActivityType ThirdPartyFee = new("THIRD_PARTY_FEE");

    /// <summary>
    /// Refunded fees from a third-party platform.
    /// </summary>
    public static readonly ActivityType ThirdPartyFeeRefund = new("THIRD_PARTY_FEE_REFUND");

    /// <summary>
    /// The balance change due to a money transfer. Note that this type is never returned by the Payouts API.
    /// </summary>
    public static readonly ActivityType Payout = new("PAYOUT");

    /// <summary>
    /// Indicates that the portion of each payment withheld by Square was automatically converted into bitcoin using Cash App. The seller manages their bitcoin in their Cash App account.
    /// </summary>
    public static readonly ActivityType AutomaticBitcoinConversions = new("AUTOMATIC_BITCOIN_CONVERSIONS");

    /// <summary>
    /// Indicates that a withheld payment, which was scheduled to be converted into bitcoin using Cash App, was deposited back to the Square payments balance.
    /// </summary>
    public static readonly ActivityType AutomaticBitcoinConversionsReversed = new(
        "AUTOMATIC_BITCOIN_CONVERSIONS_REVERSED");

    /// <summary>
    /// Indicates that a repayment toward the outstanding balance on the seller's Square credit card was made.
    /// </summary>
    public static readonly ActivityType CreditCardRepayment = new("CREDIT_CARD_REPAYMENT");

    /// <summary>
    /// Indicates that a repayment toward the outstanding balance on the seller's Square credit card was reversed.
    /// </summary>
    public static readonly ActivityType CreditCardRepaymentReversed = new("CREDIT_CARD_REPAYMENT_REVERSED");

    /// <summary>
    /// Cashback amount given by a Square Local Offers seller to their customer for a purchase.
    /// </summary>
    public static readonly ActivityType LocalOffersCashback = new("LOCAL_OFFERS_CASHBACK");

    /// <summary>
    /// A commission fee paid by a Square Local Offers seller to Square for a purchase discovered through Square Local Offers.
    /// </summary>
    public static readonly ActivityType LocalOffersFee = new("LOCAL_OFFERS_FEE");

    /// <summary>
    /// When activating Percentage Processing, a credit is applied to the seller’s account to offset any negative balance caused by a dispute.
    /// </summary>
    public static readonly ActivityType PercentageProcessingEnrollment = new("PERCENTAGE_PROCESSING_ENROLLMENT");

    /// <summary>
    /// Deducting the outstanding Percentage Processing balance from the seller’s account. It's the final installment in repaying the dispute-induced negative balance through percentage processing.
    /// </summary>
    public static readonly ActivityType PercentageProcessingDeactivation = new("PERCENTAGE_PROCESSING_DEACTIVATION");

    /// <summary>
    /// Withheld funds from a payment to cover a negative balance. It's an installment to repay the amount from a dispute that had been offset during Percentage Processing enrollment.
    /// </summary>
    public static readonly ActivityType PercentageProcessingRepayment = new("PERCENTAGE_PROCESSING_REPAYMENT");

    /// <summary>
    /// The reversal of a percentage processing repayment that happens for example when a refund is issued for a payment.
    /// </summary>
    public static readonly ActivityType PercentageProcessingRepaymentReversed = new(
        "PERCENTAGE_PROCESSING_REPAYMENT_REVERSED");

    /// <summary>
    /// The processing fee for a payment. If sellers opt for Gross Settlement, i.e., direct bank withdrawal instead of deducting fees from daily sales, the processing fee is recorded separately as a new payout entry, not part of the CHARGE payout entry.
    /// </summary>
    public static readonly ActivityType ProcessingFee = new("PROCESSING_FEE");

    /// <summary>
    /// The processing fee for a payment refund issued by sellers enrolled in Gross Settlement. The refunded processing fee is recorded separately as a new payout entry, not part of the REFUND payout entry.
    /// </summary>
    public static readonly ActivityType ProcessingFeeRefund = new("PROCESSING_FEE_REFUND");

    /// <summary>
    /// When undoing a processing fee refund in a Gross Settlement payment, this payout entry type is used.
    /// </summary>
    public static readonly ActivityType UndoProcessingFeeRefund = new("UNDO_PROCESSING_FEE_REFUND");

    /// <summary>
    /// Fee collected during the sale or reload of a gift card. This fee, which is a portion of the amount loaded on the gift card, is deducted from the merchant's payment balance.
    /// </summary>
    public static readonly ActivityType GiftCardLoadFee = new("GIFT_CARD_LOAD_FEE");

    /// <summary>
    /// Refund for fee charged during the sale or reload of a gift card.
    /// </summary>
    public static readonly ActivityType GiftCardLoadFeeRefund = new("GIFT_CARD_LOAD_FEE_REFUND");

    /// <summary>
    /// The undo of a refund for a fee charged during the sale or reload of a gift card.
    /// </summary>
    public static readonly ActivityType UndoGiftCardLoadFeeRefund = new("UNDO_GIFT_CARD_LOAD_FEE_REFUND");

    /// <summary>
    /// A transfer of funds to a banking folder. In the United States, the folder name is 'Checking Folder'; in Canada, it's 'Balance Folder.'
    /// </summary>
    public static readonly ActivityType BalanceFoldersTransfer = new("BALANCE_FOLDERS_TRANSFER");

    /// <summary>
    /// A reversal of transfer of funds from a banking folder. In the United States, the folder name is 'Checking Folder'; in Canada, it's 'Balance Folder.'
    /// </summary>
    public static readonly ActivityType BalanceFoldersTransferReversed = new("BALANCE_FOLDERS_TRANSFER_REVERSED");

    /// <summary>
    /// A transfer of gift card funds to a central gift card pool account. In franchises, when gift cards are loaded or reloaded at any location, the money transfers to the franchisor's account.
    /// </summary>
    public static readonly ActivityType GiftCardPoolTransfer = new("GIFT_CARD_POOL_TRANSFER");

    /// <summary>
    /// A reversal of transfer of gift card funds from a central gift card pool account. In franchises, when gift cards are loaded or reloaded at any location, the money transfers to the franchisor's account.
    /// </summary>
    public static readonly ActivityType GiftCardPoolTransferReversed = new("GIFT_CARD_POOL_TRANSFER_REVERSED");

    /// <summary>
    /// A payroll payment that was transferred to a team member’s bank account.
    /// </summary>
    public static readonly ActivityType SquarePayrollTransfer = new("SQUARE_PAYROLL_TRANSFER");

    /// <summary>
    /// A payroll payment to a team member’s bank account that was deposited back to the seller’s account by Square.
    /// </summary>
    public static readonly ActivityType SquarePayrollTransferReversed = new("SQUARE_PAYROLL_TRANSFER_REVERSED");

    public TResult Match<TResult>(Func<TResult> onAdjustment,
        Func<TResult> onAppFeeRefund,
        Func<TResult> onAppFeeRevenue,
        Func<TResult> onAutomaticSavings,
        Func<TResult> onAutomaticSavingsReversed,
        Func<TResult> onCharge,
        Func<TResult> onDepositFee,
        Func<TResult> onDepositFeeReversed,
        Func<TResult> onDispute,
        Func<TResult> onEscheatment,
        Func<TResult> onFee,
        Func<TResult> onFreeProcessing,
        Func<TResult> onHoldAdjustment,
        Func<TResult> onInitialBalanceChange,
        Func<TResult> onMoneyTransfer,
        Func<TResult> onMoneyTransferReversal,
        Func<TResult> onOpenDispute,
        Func<TResult> onOther,
        Func<TResult> onOtherAdjustment,
        Func<TResult> onPaidServiceFee,
        Func<TResult> onPaidServiceFeeRefund,
        Func<TResult> onRedemptionCode,
        Func<TResult> onRefund,
        Func<TResult> onReleaseAdjustment,
        Func<TResult> onReserveHold,
        Func<TResult> onReserveRelease,
        Func<TResult> onReturnedPayout,
        Func<TResult> onSquareCapitalPayment,
        Func<TResult> onSquareCapitalReversedPayment,
        Func<TResult> onSubscriptionFee,
        Func<TResult> onSubscriptionFeePaidRefund,
        Func<TResult> onSubscriptionFeeRefund,
        Func<TResult> onTaxOnFee,
        Func<TResult> onThirdPartyFee,
        Func<TResult> onThirdPartyFeeRefund,
        Func<TResult> onPayout,
        Func<TResult> onAutomaticBitcoinConversions,
        Func<TResult> onAutomaticBitcoinConversionsReversed,
        Func<TResult> onCreditCardRepayment,
        Func<TResult> onCreditCardRepaymentReversed,
        Func<TResult> onLocalOffersCashback,
        Func<TResult> onLocalOffersFee,
        Func<TResult> onPercentageProcessingEnrollment,
        Func<TResult> onPercentageProcessingDeactivation,
        Func<TResult> onPercentageProcessingRepayment,
        Func<TResult> onPercentageProcessingRepaymentReversed,
        Func<TResult> onProcessingFee,
        Func<TResult> onProcessingFeeRefund,
        Func<TResult> onUndoProcessingFeeRefund,
        Func<TResult> onGiftCardLoadFee,
        Func<TResult> onGiftCardLoadFeeRefund,
        Func<TResult> onUndoGiftCardLoadFeeRefund,
        Func<TResult> onBalanceFoldersTransfer,
        Func<TResult> onBalanceFoldersTransferReversed,
        Func<TResult> onGiftCardPoolTransfer,
        Func<TResult> onGiftCardPoolTransferReversed,
        Func<TResult> onSquarePayrollTransfer,
        Func<TResult> onSquarePayrollTransferReversed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Adjustment => onAdjustment(),
            _ when this == AppFeeRefund => onAppFeeRefund(),
            _ when this == AppFeeRevenue => onAppFeeRevenue(),
            _ when this == AutomaticSavings => onAutomaticSavings(),
            _ when this == AutomaticSavingsReversed => onAutomaticSavingsReversed(),
            _ when this == Charge => onCharge(),
            _ when this == DepositFee => onDepositFee(),
            _ when this == DepositFeeReversed => onDepositFeeReversed(),
            _ when this == Dispute => onDispute(),
            _ when this == Escheatment => onEscheatment(),
            _ when this == Fee => onFee(),
            _ when this == FreeProcessing => onFreeProcessing(),
            _ when this == HoldAdjustment => onHoldAdjustment(),
            _ when this == InitialBalanceChange => onInitialBalanceChange(),
            _ when this == MoneyTransfer => onMoneyTransfer(),
            _ when this == MoneyTransferReversal => onMoneyTransferReversal(),
            _ when this == OpenDispute => onOpenDispute(),
            _ when this == Other => onOther(),
            _ when this == OtherAdjustment => onOtherAdjustment(),
            _ when this == PaidServiceFee => onPaidServiceFee(),
            _ when this == PaidServiceFeeRefund => onPaidServiceFeeRefund(),
            _ when this == RedemptionCode => onRedemptionCode(),
            _ when this == Refund => onRefund(),
            _ when this == ReleaseAdjustment => onReleaseAdjustment(),
            _ when this == ReserveHold => onReserveHold(),
            _ when this == ReserveRelease => onReserveRelease(),
            _ when this == ReturnedPayout => onReturnedPayout(),
            _ when this == SquareCapitalPayment => onSquareCapitalPayment(),
            _ when this == SquareCapitalReversedPayment => onSquareCapitalReversedPayment(),
            _ when this == SubscriptionFee => onSubscriptionFee(),
            _ when this == SubscriptionFeePaidRefund => onSubscriptionFeePaidRefund(),
            _ when this == SubscriptionFeeRefund => onSubscriptionFeeRefund(),
            _ when this == TaxOnFee => onTaxOnFee(),
            _ when this == ThirdPartyFee => onThirdPartyFee(),
            _ when this == ThirdPartyFeeRefund => onThirdPartyFeeRefund(),
            _ when this == Payout => onPayout(),
            _ when this == AutomaticBitcoinConversions => onAutomaticBitcoinConversions(),
            _ when this == AutomaticBitcoinConversionsReversed => onAutomaticBitcoinConversionsReversed(),
            _ when this == CreditCardRepayment => onCreditCardRepayment(),
            _ when this == CreditCardRepaymentReversed => onCreditCardRepaymentReversed(),
            _ when this == LocalOffersCashback => onLocalOffersCashback(),
            _ when this == LocalOffersFee => onLocalOffersFee(),
            _ when this == PercentageProcessingEnrollment => onPercentageProcessingEnrollment(),
            _ when this == PercentageProcessingDeactivation => onPercentageProcessingDeactivation(),
            _ when this == PercentageProcessingRepayment => onPercentageProcessingRepayment(),
            _ when this == PercentageProcessingRepaymentReversed => onPercentageProcessingRepaymentReversed(),
            _ when this == ProcessingFee => onProcessingFee(),
            _ when this == ProcessingFeeRefund => onProcessingFeeRefund(),
            _ when this == UndoProcessingFeeRefund => onUndoProcessingFeeRefund(),
            _ when this == GiftCardLoadFee => onGiftCardLoadFee(),
            _ when this == GiftCardLoadFeeRefund => onGiftCardLoadFeeRefund(),
            _ when this == UndoGiftCardLoadFeeRefund => onUndoGiftCardLoadFeeRefund(),
            _ when this == BalanceFoldersTransfer => onBalanceFoldersTransfer(),
            _ when this == BalanceFoldersTransferReversed => onBalanceFoldersTransferReversed(),
            _ when this == GiftCardPoolTransfer => onGiftCardPoolTransfer(),
            _ when this == GiftCardPoolTransferReversed => onGiftCardPoolTransferReversed(),
            _ when this == SquarePayrollTransfer => onSquarePayrollTransfer(),
            _ when this == SquarePayrollTransferReversed => onSquarePayrollTransferReversed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdjustment,
        Action onAppFeeRefund,
        Action onAppFeeRevenue,
        Action onAutomaticSavings,
        Action onAutomaticSavingsReversed,
        Action onCharge,
        Action onDepositFee,
        Action onDepositFeeReversed,
        Action onDispute,
        Action onEscheatment,
        Action onFee,
        Action onFreeProcessing,
        Action onHoldAdjustment,
        Action onInitialBalanceChange,
        Action onMoneyTransfer,
        Action onMoneyTransferReversal,
        Action onOpenDispute,
        Action onOther,
        Action onOtherAdjustment,
        Action onPaidServiceFee,
        Action onPaidServiceFeeRefund,
        Action onRedemptionCode,
        Action onRefund,
        Action onReleaseAdjustment,
        Action onReserveHold,
        Action onReserveRelease,
        Action onReturnedPayout,
        Action onSquareCapitalPayment,
        Action onSquareCapitalReversedPayment,
        Action onSubscriptionFee,
        Action onSubscriptionFeePaidRefund,
        Action onSubscriptionFeeRefund,
        Action onTaxOnFee,
        Action onThirdPartyFee,
        Action onThirdPartyFeeRefund,
        Action onPayout,
        Action onAutomaticBitcoinConversions,
        Action onAutomaticBitcoinConversionsReversed,
        Action onCreditCardRepayment,
        Action onCreditCardRepaymentReversed,
        Action onLocalOffersCashback,
        Action onLocalOffersFee,
        Action onPercentageProcessingEnrollment,
        Action onPercentageProcessingDeactivation,
        Action onPercentageProcessingRepayment,
        Action onPercentageProcessingRepaymentReversed,
        Action onProcessingFee,
        Action onProcessingFeeRefund,
        Action onUndoProcessingFeeRefund,
        Action onGiftCardLoadFee,
        Action onGiftCardLoadFeeRefund,
        Action onUndoGiftCardLoadFeeRefund,
        Action onBalanceFoldersTransfer,
        Action onBalanceFoldersTransferReversed,
        Action onGiftCardPoolTransfer,
        Action onGiftCardPoolTransferReversed,
        Action onSquarePayrollTransfer,
        Action onSquarePayrollTransferReversed,
        Action<string> otherwise)
    {
        if (this == Adjustment) onAdjustment();
        else if (this == AppFeeRefund) onAppFeeRefund();
        else if (this == AppFeeRevenue) onAppFeeRevenue();
        else if (this == AutomaticSavings) onAutomaticSavings();
        else if (this == AutomaticSavingsReversed) onAutomaticSavingsReversed();
        else if (this == Charge) onCharge();
        else if (this == DepositFee) onDepositFee();
        else if (this == DepositFeeReversed) onDepositFeeReversed();
        else if (this == Dispute) onDispute();
        else if (this == Escheatment) onEscheatment();
        else if (this == Fee) onFee();
        else if (this == FreeProcessing) onFreeProcessing();
        else if (this == HoldAdjustment) onHoldAdjustment();
        else if (this == InitialBalanceChange) onInitialBalanceChange();
        else if (this == MoneyTransfer) onMoneyTransfer();
        else if (this == MoneyTransferReversal) onMoneyTransferReversal();
        else if (this == OpenDispute) onOpenDispute();
        else if (this == Other) onOther();
        else if (this == OtherAdjustment) onOtherAdjustment();
        else if (this == PaidServiceFee) onPaidServiceFee();
        else if (this == PaidServiceFeeRefund) onPaidServiceFeeRefund();
        else if (this == RedemptionCode) onRedemptionCode();
        else if (this == Refund) onRefund();
        else if (this == ReleaseAdjustment) onReleaseAdjustment();
        else if (this == ReserveHold) onReserveHold();
        else if (this == ReserveRelease) onReserveRelease();
        else if (this == ReturnedPayout) onReturnedPayout();
        else if (this == SquareCapitalPayment) onSquareCapitalPayment();
        else if (this == SquareCapitalReversedPayment) onSquareCapitalReversedPayment();
        else if (this == SubscriptionFee) onSubscriptionFee();
        else if (this == SubscriptionFeePaidRefund) onSubscriptionFeePaidRefund();
        else if (this == SubscriptionFeeRefund) onSubscriptionFeeRefund();
        else if (this == TaxOnFee) onTaxOnFee();
        else if (this == ThirdPartyFee) onThirdPartyFee();
        else if (this == ThirdPartyFeeRefund) onThirdPartyFeeRefund();
        else if (this == Payout) onPayout();
        else if (this == AutomaticBitcoinConversions) onAutomaticBitcoinConversions();
        else if (this == AutomaticBitcoinConversionsReversed) onAutomaticBitcoinConversionsReversed();
        else if (this == CreditCardRepayment) onCreditCardRepayment();
        else if (this == CreditCardRepaymentReversed) onCreditCardRepaymentReversed();
        else if (this == LocalOffersCashback) onLocalOffersCashback();
        else if (this == LocalOffersFee) onLocalOffersFee();
        else if (this == PercentageProcessingEnrollment) onPercentageProcessingEnrollment();
        else if (this == PercentageProcessingDeactivation) onPercentageProcessingDeactivation();
        else if (this == PercentageProcessingRepayment) onPercentageProcessingRepayment();
        else if (this == PercentageProcessingRepaymentReversed) onPercentageProcessingRepaymentReversed();
        else if (this == ProcessingFee) onProcessingFee();
        else if (this == ProcessingFeeRefund) onProcessingFeeRefund();
        else if (this == UndoProcessingFeeRefund) onUndoProcessingFeeRefund();
        else if (this == GiftCardLoadFee) onGiftCardLoadFee();
        else if (this == GiftCardLoadFeeRefund) onGiftCardLoadFeeRefund();
        else if (this == UndoGiftCardLoadFeeRefund) onUndoGiftCardLoadFeeRefund();
        else if (this == BalanceFoldersTransfer) onBalanceFoldersTransfer();
        else if (this == BalanceFoldersTransferReversed) onBalanceFoldersTransferReversed();
        else if (this == GiftCardPoolTransfer) onGiftCardPoolTransfer();
        else if (this == GiftCardPoolTransferReversed) onGiftCardPoolTransferReversed();
        else if (this == SquarePayrollTransfer) onSquarePayrollTransfer();
        else if (this == SquarePayrollTransferReversed) onSquarePayrollTransferReversed();
        else otherwise(Value);
    }
}
