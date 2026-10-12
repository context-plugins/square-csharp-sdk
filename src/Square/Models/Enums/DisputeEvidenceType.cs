using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of the dispute evidence.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeEvidenceType>))]
public sealed record DisputeEvidenceType : OpenStringEnum<DisputeEvidenceType>
{
    private DisputeEvidenceType(string value) : base(value)
    {
    }

    /// <summary>
    /// Square assumes this evidence type if you do not provide a type when uploading evidence.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType GenericEvidence = new("GENERIC_EVIDENCE");

    /// <summary>
    /// Server or activity logs that show proof of the cardholder’s identity and that the
    /// cardholder successfully ordered and received the goods (digitally or otherwise).
    /// Example evidence includes IP addresses, corresponding timestamps/dates, cardholder’s name and email
    /// address linked to a cardholder profile held by the seller, proof the same device and card (used
    /// in dispute) were previously used in prior undisputed transaction, and any related detailed activity.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType OnlineOrAppAccessLog = new("ONLINE_OR_APP_ACCESS_LOG");

    /// <summary>
    /// Evidence that the cardholder did provide authorization for the charge.
    /// Example evidence includes a signed credit card authorization.
    /// <para>
    /// Use when uploading evidence as a file.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType AuthorizationDocumentation = new("AUTHORIZATION_DOCUMENTATION");

    /// <summary>
    /// Evidence that the cardholder acknowledged your refund or cancellation policy.
    /// Example evidence includes a signature or checkbox showing the cardholder’s acknowledgement of your
    /// refund or cancellation policy.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType CancellationOrRefundDocumentation = new(
        "CANCELLATION_OR_REFUND_DOCUMENTATION");

    /// <summary>
    /// Evidence that shows relevant communication with the cardholder.
    /// Example evidence includes emails or texts that show the cardholder received goods/services or
    /// demonstrate cardholder satisfaction.
    /// <para>
    /// Use when uploading evidence as a file.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType CardholderCommunication = new("CARDHOLDER_COMMUNICATION");

    /// <summary>
    /// Evidence that validates the customer's identity.
    /// Example evidence includes personally identifiable details such as name, email address, purchaser IP
    /// address, and a copy of the cardholder ID.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType CardholderInformation = new("CARDHOLDER_INFORMATION");

    /// <summary>
    /// Evidence that shows proof of the sale/transaction.
    /// Example evidence includes an invoice, contract, or other item showing the customer’s acknowledgement
    /// of the purchase and your terms.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType PurchaseAcknowledgement = new("PURCHASE_ACKNOWLEDGEMENT");

    /// <summary>
    /// Evidence that shows the charges in question are valid and distinct from one another.
    /// Example evidence includes receipts, shipping labels, and invoices along with their distinct payment IDs.
    /// <para>
    /// Use when uploading evidence as a file.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType DuplicateChargeDocumentation = new("DUPLICATE_CHARGE_DOCUMENTATION");

    /// <summary>
    /// A description of the product or service sold.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType ProductOrServiceDescription = new("PRODUCT_OR_SERVICE_DESCRIPTION");

    /// <summary>
    /// A receipt or message sent to the cardholder detailing the charge.
    /// Note: You do not need to upload the Square receipt; Square submits the receipt on your behalf.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType Receipt = new("RECEIPT");

    /// <summary>
    /// Evidence that the service was provided to the cardholder or the expected date that services will be rendered.
    /// Example evidence includes a signed delivery form, work order, expected delivery date, or other written agreements.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType ServiceReceivedDocumentation = new("SERVICE_RECEIVED_DOCUMENTATION");

    /// <summary>
    /// Evidence that shows the product was provided to the cardholder or the expected date of delivery.
    /// Example evidence includes a signed delivery form or written agreement acknowledging receipt of the goods or services.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType ProofOfDeliveryDocumentation = new("PROOF_OF_DELIVERY_DOCUMENTATION");

    /// <summary>
    /// Evidence that shows the cardholder previously processed transactions on the same card and did not dispute them.
    /// Note: Square automatically provides up to five distinct Square receipts for related transactions, when available.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType RelatedTransactionDocumentation = new(
        "RELATED_TRANSACTION_DOCUMENTATION");

    /// <summary>
    /// An explanation of why the cardholder’s claim is invalid.
    /// Example evidence includes an explanation of why each distinct charge is a legitimate purchase, why the cardholder’s claim
    /// for credit owed due to their attempt to cancel, return, or refund is invalid per your stated policy and cardholder
    /// agreement, or an explanation of how the cardholder did not attempt to remedy the issue with you first to receive credit.
    /// <para>
    /// Use when uploading evidence as a file or string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType RebuttalExplanation = new("REBUTTAL_EXPLANATION");

    /// <summary>
    /// The tracking number for the order provided by the shipping carrier. If you have multiple numbers, they need to be
    /// submitted individually as separate pieces of evidence.
    /// <para>
    /// Use when uploading evidence as a string.
    /// </para>
    /// </summary>
    public static readonly DisputeEvidenceType TrackingNumber = new("TRACKING_NUMBER");

    public TResult Match<TResult>(Func<TResult> onGenericEvidence,
        Func<TResult> onOnlineOrAppAccessLog,
        Func<TResult> onAuthorizationDocumentation,
        Func<TResult> onCancellationOrRefundDocumentation,
        Func<TResult> onCardholderCommunication,
        Func<TResult> onCardholderInformation,
        Func<TResult> onPurchaseAcknowledgement,
        Func<TResult> onDuplicateChargeDocumentation,
        Func<TResult> onProductOrServiceDescription,
        Func<TResult> onReceipt,
        Func<TResult> onServiceReceivedDocumentation,
        Func<TResult> onProofOfDeliveryDocumentation,
        Func<TResult> onRelatedTransactionDocumentation,
        Func<TResult> onRebuttalExplanation,
        Func<TResult> onTrackingNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GenericEvidence => onGenericEvidence(),
            _ when this == OnlineOrAppAccessLog => onOnlineOrAppAccessLog(),
            _ when this == AuthorizationDocumentation => onAuthorizationDocumentation(),
            _ when this == CancellationOrRefundDocumentation => onCancellationOrRefundDocumentation(),
            _ when this == CardholderCommunication => onCardholderCommunication(),
            _ when this == CardholderInformation => onCardholderInformation(),
            _ when this == PurchaseAcknowledgement => onPurchaseAcknowledgement(),
            _ when this == DuplicateChargeDocumentation => onDuplicateChargeDocumentation(),
            _ when this == ProductOrServiceDescription => onProductOrServiceDescription(),
            _ when this == Receipt => onReceipt(),
            _ when this == ServiceReceivedDocumentation => onServiceReceivedDocumentation(),
            _ when this == ProofOfDeliveryDocumentation => onProofOfDeliveryDocumentation(),
            _ when this == RelatedTransactionDocumentation => onRelatedTransactionDocumentation(),
            _ when this == RebuttalExplanation => onRebuttalExplanation(),
            _ when this == TrackingNumber => onTrackingNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onGenericEvidence,
        Action onOnlineOrAppAccessLog,
        Action onAuthorizationDocumentation,
        Action onCancellationOrRefundDocumentation,
        Action onCardholderCommunication,
        Action onCardholderInformation,
        Action onPurchaseAcknowledgement,
        Action onDuplicateChargeDocumentation,
        Action onProductOrServiceDescription,
        Action onReceipt,
        Action onServiceReceivedDocumentation,
        Action onProofOfDeliveryDocumentation,
        Action onRelatedTransactionDocumentation,
        Action onRebuttalExplanation,
        Action onTrackingNumber,
        Action<string> otherwise)
    {
        if (this == GenericEvidence) onGenericEvidence();
        else if (this == OnlineOrAppAccessLog) onOnlineOrAppAccessLog();
        else if (this == AuthorizationDocumentation) onAuthorizationDocumentation();
        else if (this == CancellationOrRefundDocumentation) onCancellationOrRefundDocumentation();
        else if (this == CardholderCommunication) onCardholderCommunication();
        else if (this == CardholderInformation) onCardholderInformation();
        else if (this == PurchaseAcknowledgement) onPurchaseAcknowledgement();
        else if (this == DuplicateChargeDocumentation) onDuplicateChargeDocumentation();
        else if (this == ProductOrServiceDescription) onProductOrServiceDescription();
        else if (this == Receipt) onReceipt();
        else if (this == ServiceReceivedDocumentation) onServiceReceivedDocumentation();
        else if (this == ProofOfDeliveryDocumentation) onProofOfDeliveryDocumentation();
        else if (this == RelatedTransactionDocumentation) onRelatedTransactionDocumentation();
        else if (this == RebuttalExplanation) onRebuttalExplanation();
        else if (this == TrackingNumber) onTrackingNumber();
        else otherwise(Value);
    }
}
