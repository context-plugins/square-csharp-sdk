using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the bank account payment's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderBankAccountDetailsStatus>))]
public sealed record TenderBankAccountDetailsStatus : StringEnum<TenderBankAccountDetailsStatus>
{
    private TenderBankAccountDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The bank account payment is in progress.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Pending = new("PENDING");

    /// <summary>
    /// The bank account payment has been completed.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Completed = new("COMPLETED");

    /// <summary>
    /// The bank account payment failed.
    /// </summary>
    public static readonly TenderBankAccountDetailsStatus Failed = new("FAILED");

    public static TenderBankAccountDetailsStatus FromValue(string value) => FromValueCore(value);
}
