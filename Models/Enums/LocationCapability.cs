using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The capabilities a location might have.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationCapability>))]
public sealed record LocationCapability : StringEnum<LocationCapability>
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

    public static LocationCapability FromValue(string value) => FromValueCore(value);
}
