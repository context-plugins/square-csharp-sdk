using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ActionCancelReason>))]
public sealed record ActionCancelReason : OpenStringEnum<ActionCancelReason>
{
    private ActionCancelReason(string value) : base(value)
    {
    }

    /// <summary>
    /// A person canceled the <c>TerminalCheckout</c> from a Square device.
    /// </summary>
    public static readonly ActionCancelReason BuyerCanceled = new("BUYER_CANCELED");

    /// <summary>
    /// A client canceled the <c>TerminalCheckout</c> using the API.
    /// </summary>
    public static readonly ActionCancelReason SellerCanceled = new("SELLER_CANCELED");

    /// <summary>
    /// The <c>TerminalCheckout</c> timed out (see <c>deadline_duration</c> on the <c>TerminalCheckout</c>).
    /// </summary>
    public static readonly ActionCancelReason TimedOut = new("TIMED_OUT");

    public TResult Match<TResult>(Func<TResult> onBuyerCanceled,
        Func<TResult> onSellerCanceled,
        Func<TResult> onTimedOut,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BuyerCanceled => onBuyerCanceled(),
            _ when this == SellerCanceled => onSellerCanceled(),
            _ when this == TimedOut => onTimedOut(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuyerCanceled, Action onSellerCanceled, Action onTimedOut, Action<string> otherwise)
    {
        if (this == BuyerCanceled) onBuyerCanceled();
        else if (this == SellerCanceled) onSellerCanceled();
        else if (this == TimedOut) onTimedOut();
        else otherwise(Value);
    }
}
