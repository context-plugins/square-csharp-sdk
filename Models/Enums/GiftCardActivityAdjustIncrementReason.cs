using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the reason for adding money to a <see href="entity:GiftCard">gift card</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardActivityAdjustIncrementReason>))]
public sealed record GiftCardActivityAdjustIncrementReason : StringEnum<GiftCardActivityAdjustIncrementReason>
{
    private GiftCardActivityAdjustIncrementReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller gifted a complimentary gift card balance increase.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason Complimentary = new("COMPLIMENTARY");

    /// <summary>
    /// The seller increased the gift card balance
    /// to accommodate support issues.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason SupportIssue = new("SUPPORT_ISSUE");

    /// <summary>
    /// The transaction is voided.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason TransactionVoided = new("TRANSACTION_VOIDED");

    public static GiftCardActivityAdjustIncrementReason FromValue(string value) => FromValueCore(value);
}
