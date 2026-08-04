using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Represents the type of payout fee that can incur as part of a payout.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutFeeType>))]
public sealed record PayoutFeeType : StringEnum<PayoutFeeType>
{
    private PayoutFeeType(string value) : base(value)
    {
    }

    /// <summary>
    /// Fee type associated with transfers.
    /// </summary>
    public static readonly PayoutFeeType TransferFee = new("TRANSFER_FEE");

    /// <summary>
    /// Taxes associated with the transfer fee.
    /// </summary>
    public static readonly PayoutFeeType TaxOnTransferFee = new("TAX_ON_TRANSFER_FEE");

    public static PayoutFeeType FromValue(string value) => FromValueCore(value);
}
