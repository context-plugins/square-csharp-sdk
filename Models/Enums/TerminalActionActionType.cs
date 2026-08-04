using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalActionActionType>))]
public sealed record TerminalActionActionType : StringEnum<TerminalActionActionType>
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

    public static TerminalActionActionType FromValue(string value) => FromValueCore(value);
}
