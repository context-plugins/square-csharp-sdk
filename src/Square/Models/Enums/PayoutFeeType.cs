using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Represents the type of payout fee that can incur as part of a payout.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayoutFeeType>))]
public sealed record PayoutFeeType : OpenStringEnum<PayoutFeeType>
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

    public TResult Match<TResult>(Func<TResult> onTransferFee,
        Func<TResult> onTaxOnTransferFee,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TransferFee => onTransferFee(),
            _ when this == TaxOnTransferFee => onTaxOnTransferFee(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransferFee, Action onTaxOnTransferFee, Action<string> otherwise)
    {
        if (this == TransferFee) onTransferFee();
        else if (this == TaxOnTransferFee) onTaxOnTransferFee();
        else otherwise(Value);
    }
}
