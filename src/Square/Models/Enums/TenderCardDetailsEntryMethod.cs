using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the method used to enter the card's details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderCardDetailsEntryMethod>))]
public sealed record TenderCardDetailsEntryMethod : OpenStringEnum<TenderCardDetailsEntryMethod>
{
    private TenderCardDetailsEntryMethod(string value) : base(value)
    {
    }

    /// <summary>
    /// The card was swiped through a Square reader or Square stand.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Swiped = new("SWIPED");

    /// <summary>
    /// The card information was keyed manually into Square Point of Sale or a
    /// Square-hosted web form.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Keyed = new("KEYED");

    /// <summary>
    /// The card was processed via EMV with a Square reader.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Emv = new("EMV");

    /// <summary>
    /// The buyer's card details were already on file with Square.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod OnFile = new("ON_FILE");

    /// <summary>
    /// The card was processed via a contactless (i.e., NFC) transaction
    /// with a Square reader.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Contactless = new("CONTACTLESS");

    public TResult Match<TResult>(Func<TResult> onSwiped,
        Func<TResult> onKeyed,
        Func<TResult> onEmv,
        Func<TResult> onOnFile,
        Func<TResult> onContactless,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Swiped => onSwiped(),
            _ when this == Keyed => onKeyed(),
            _ when this == Emv => onEmv(),
            _ when this == OnFile => onOnFile(),
            _ when this == Contactless => onContactless(),
            _ => otherwise(Value)
        };

    public void Match(Action onSwiped,
        Action onKeyed,
        Action onEmv,
        Action onOnFile,
        Action onContactless,
        Action<string> otherwise)
    {
        if (this == Swiped) onSwiped();
        else if (this == Keyed) onKeyed();
        else if (this == Emv) onEmv();
        else if (this == OnFile) onOnFile();
        else if (this == Contactless) onContactless();
        else otherwise(Value);
    }
}
