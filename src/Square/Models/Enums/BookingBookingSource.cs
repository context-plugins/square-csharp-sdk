using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported sources a booking was created from.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingBookingSource>))]
public sealed record BookingBookingSource : OpenStringEnum<BookingBookingSource>
{
    private BookingBookingSource(string value) : base(value)
    {
    }

    /// <summary>
    /// The booking was created by a seller from a Square Appointments application, such as the Square Appointments Dashboard or a Square Appointments mobile app.
    /// </summary>
    public static readonly BookingBookingSource FirstPartyMerchant = new("FIRST_PARTY_MERCHANT");

    /// <summary>
    /// The booking was created by a buyer from a Square Appointments application, such as Square Online Booking Site.
    /// </summary>
    public static readonly BookingBookingSource FirstPartyBuyer = new("FIRST_PARTY_BUYER");

    /// <summary>
    /// The booking was created by a buyer created from a third-party application.
    /// </summary>
    public static readonly BookingBookingSource ThirdPartyBuyer = new("THIRD_PARTY_BUYER");

    /// <summary>
    /// The booking was created by a seller or a buyer from the Square Bookings API.
    /// </summary>
    public static readonly BookingBookingSource Api = new("API");

    public TResult Match<TResult>(Func<TResult> onFirstPartyMerchant,
        Func<TResult> onFirstPartyBuyer,
        Func<TResult> onThirdPartyBuyer,
        Func<TResult> onApi,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FirstPartyMerchant => onFirstPartyMerchant(),
            _ when this == FirstPartyBuyer => onFirstPartyBuyer(),
            _ when this == ThirdPartyBuyer => onThirdPartyBuyer(),
            _ when this == Api => onApi(),
            _ => otherwise(Value)
        };

    public void Match(Action onFirstPartyMerchant,
        Action onFirstPartyBuyer,
        Action onThirdPartyBuyer,
        Action onApi,
        Action<string> otherwise)
    {
        if (this == FirstPartyMerchant) onFirstPartyMerchant();
        else if (this == FirstPartyBuyer) onFirstPartyBuyer();
        else if (this == ThirdPartyBuyer) onThirdPartyBuyer();
        else if (this == Api) onApi();
        else otherwise(Value);
    }
}
