using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The capabilities a location might have.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationCapability>))]
public sealed record LocationCapability : OpenStringEnum<LocationCapability>
{
    private LocationCapability(string value) : base(value)
    {
    }

    /// <summary>
    /// The capability to process credit card transactions with Square.
    /// </summary>
    public static readonly LocationCapability CreditCardProcessing = new("CREDIT_CARD_PROCESSING");

    /// <summary>
    /// The capability to receive automatic transfers from Square.
    /// </summary>
    public static readonly LocationCapability AutomaticTransfers = new("AUTOMATIC_TRANSFERS");

    /// <summary>
    /// The capability to process unlinked refunds with Square.
    /// </summary>
    public static readonly LocationCapability UnlinkedRefunds = new("UNLINKED_REFUNDS");

    public TResult Match<TResult>(Func<TResult> onCreditCardProcessing,
        Func<TResult> onAutomaticTransfers,
        Func<TResult> onUnlinkedRefunds,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreditCardProcessing => onCreditCardProcessing(),
            _ when this == AutomaticTransfers => onAutomaticTransfers(),
            _ when this == UnlinkedRefunds => onUnlinkedRefunds(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreditCardProcessing,
        Action onAutomaticTransfers,
        Action onUnlinkedRefunds,
        Action<string> otherwise)
    {
        if (this == CreditCardProcessing) onCreditCardProcessing();
        else if (this == AutomaticTransfers) onAutomaticTransfers();
        else if (this == UnlinkedRefunds) onUnlinkedRefunds();
        else otherwise(Value);
    }
}
