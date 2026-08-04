using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// List of possible destinations against which a payout can be made.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DestinationType>))]
public sealed record DestinationType : StringEnum<DestinationType>
{
    private DestinationType(string value) : base(value)
    {
    }

    /// <summary>
    /// An external bank account outside of Square.
    /// </summary>
    public static readonly DestinationType BankAccount = new("BANK_ACCOUNT");

    /// <summary>
    /// An external card outside of Square used for the transfer.
    /// </summary>
    public static readonly DestinationType Card = new("CARD");

    public static readonly DestinationType SquareBalance = new("SQUARE_BALANCE");

    /// <summary>
    /// Square Checking or Savings account (US), Square Card (CA)
    /// </summary>
    public static readonly DestinationType SquareStoredBalance = new("SQUARE_STORED_BALANCE");

    public static DestinationType FromValue(string value) => FromValueCore(value);
}
