using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalActionActionType>))]
public sealed record TerminalActionActionType : OpenStringEnum<TerminalActionActionType>
{
    private TerminalActionActionType(string value) : base(value)
    {
    }

    /// <summary>
    /// The action represents a request to display a QR code. Details are contained in
    /// the <c>qr_code_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType QrCode = new("QR_CODE");

    /// <summary>
    /// The action represents a request to check if the specific device is
    /// online or currently active with the merchant in question. Does not require an action options value.
    /// </summary>
    public static readonly TerminalActionActionType Ping = new("PING");

    /// <summary>
    /// Represents a request to save a card for future card-on-file use. Details are contained
    /// in the <c>save_card_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType SaveCard = new("SAVE_CARD");

    /// <summary>
    /// The action represents a request to capture a buyer's signature. Details are contained
    /// in the <c>signature_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType Signature = new("SIGNATURE");

    /// <summary>
    /// The action represents a request to collect a buyer's confirmation decision to the
    /// displayed terms. Details are contained in the <c>confirmation_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType Confirmation = new("CONFIRMATION");

    /// <summary>
    /// The action represents a request to display the receipt screen options. Details are
    /// contained in the <c>receipt_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType Receipt = new("RECEIPT");

    /// <summary>
    /// The action represents a request to collect a buyer's text data. Details
    /// are contained in the <c>data_collection_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType DataCollection = new("DATA_COLLECTION");

    /// <summary>
    /// The action represents a request to allow the buyer to select from provided options.
    /// Details are contained in the <c>select_options</c> object.
    /// </summary>
    public static readonly TerminalActionActionType Select = new("SELECT");

    public TResult Match<TResult>(Func<TResult> onQrCode,
        Func<TResult> onPing,
        Func<TResult> onSaveCard,
        Func<TResult> onSignature,
        Func<TResult> onConfirmation,
        Func<TResult> onReceipt,
        Func<TResult> onDataCollection,
        Func<TResult> onSelect,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == QrCode => onQrCode(),
            _ when this == Ping => onPing(),
            _ when this == SaveCard => onSaveCard(),
            _ when this == Signature => onSignature(),
            _ when this == Confirmation => onConfirmation(),
            _ when this == Receipt => onReceipt(),
            _ when this == DataCollection => onDataCollection(),
            _ when this == Select => onSelect(),
            _ => otherwise(Value)
        };

    public void Match(Action onQrCode,
        Action onPing,
        Action onSaveCard,
        Action onSignature,
        Action onConfirmation,
        Action onReceipt,
        Action onDataCollection,
        Action onSelect,
        Action<string> otherwise)
    {
        if (this == QrCode) onQrCode();
        else if (this == Ping) onPing();
        else if (this == SaveCard) onSaveCard();
        else if (this == Signature) onSignature();
        else if (this == Confirmation) onConfirmation();
        else if (this == Receipt) onReceipt();
        else if (this == DataCollection) onDataCollection();
        else if (this == Select) onSelect();
        else otherwise(Value);
    }
}
