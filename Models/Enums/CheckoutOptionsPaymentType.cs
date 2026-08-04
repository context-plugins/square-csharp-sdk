using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CheckoutOptionsPaymentType>))]
public sealed record CheckoutOptionsPaymentType : StringEnum<CheckoutOptionsPaymentType>
{
    private CheckoutOptionsPaymentType(string value) : base(value)
    {
    }

    /// <summary>
    /// Accept credit card or debit card payments via tap, dip or swipe.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType CardPresent = new("CARD_PRESENT");

    /// <summary>
    /// Launches the manual credit or debit card entry screen for the buyer to complete.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType ManualCardEntry = new("MANUAL_CARD_ENTRY");

    /// <summary>
    /// Launches the iD checkout screen for the buyer to complete.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType FelicaId = new("FELICA_ID");

    /// <summary>
    /// Launches the QUICPay checkout screen for the buyer to complete.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType FelicaQuicpay = new("FELICA_QUICPAY");

    /// <summary>
    /// Launches the Transportation Group checkout screen for the buyer to complete.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType FelicaTransportationGroup = new("FELICA_TRANSPORTATION_GROUP");

    /// <summary>
    /// Launches a checkout screen for the buyer on the Square Terminal that
    /// allows them to select a specific FeliCa brand or select the check balance screen.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType FelicaAll = new("FELICA_ALL");

    /// <summary>
    /// Replaced by <c>QR_CODE</c>.
    /// </summary>
    public static readonly CheckoutOptionsPaymentType Paypay = new("PAYPAY");

    /// <summary>
    /// Launches Square's QR Code checkout screen for the buyer to complete.
    /// Displays a single code that supports all digital wallets connected to the target
    /// Seller location (e.g. PayPay)
    /// </summary>
    public static readonly CheckoutOptionsPaymentType QrCode = new("QR_CODE");

    public static CheckoutOptionsPaymentType FromValue(string value) => FromValueCore(value);
}
