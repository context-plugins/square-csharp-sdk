using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported booking statuses.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingStatus>))]
public sealed record BookingStatus : OpenStringEnum<BookingStatus>
{
    private BookingStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// An unaccepted booking. It is visible to both sellers and customers.
    /// </summary>
    public static readonly BookingStatus Pending = new("PENDING");

    /// <summary>
    /// A customer-cancelled booking. It is visible to both the seller and the customer.
    /// </summary>
    public static readonly BookingStatus CancelledByCustomer = new("CANCELLED_BY_CUSTOMER");

    /// <summary>
    /// A seller-cancelled booking. It is visible to both the seller and the customer.
    /// </summary>
    public static readonly BookingStatus CancelledBySeller = new("CANCELLED_BY_SELLER");

    /// <summary>
    /// A declined booking. It had once been pending, but was then declined by the seller.
    /// </summary>
    public static readonly BookingStatus Declined = new("DECLINED");

    /// <summary>
    /// An accepted booking agreed to or accepted by the seller.
    /// </summary>
    public static readonly BookingStatus Accepted = new("ACCEPTED");

    /// <summary>
    /// A no-show booking. The booking was accepted at one time, but have now been marked as a no-show by
    /// the seller because the client either missed the booking or cancelled it without enough notice.
    /// </summary>
    public static readonly BookingStatus NoShow = new("NO_SHOW");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onCancelledByCustomer,
        Func<TResult> onCancelledBySeller,
        Func<TResult> onDeclined,
        Func<TResult> onAccepted,
        Func<TResult> onNoShow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == CancelledByCustomer => onCancelledByCustomer(),
            _ when this == CancelledBySeller => onCancelledBySeller(),
            _ when this == Declined => onDeclined(),
            _ when this == Accepted => onAccepted(),
            _ when this == NoShow => onNoShow(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onCancelledByCustomer,
        Action onCancelledBySeller,
        Action onDeclined,
        Action onAccepted,
        Action onNoShow,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == CancelledByCustomer) onCancelledByCustomer();
        else if (this == CancelledBySeller) onCancelledBySeller();
        else if (this == Declined) onDeclined();
        else if (this == Accepted) onAccepted();
        else if (this == NoShow) onNoShow();
        else otherwise(Value);
    }
}
