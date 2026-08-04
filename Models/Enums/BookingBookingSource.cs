using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported sources a booking was created from.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingBookingSource>))]
public sealed record BookingBookingSource : StringEnum<BookingBookingSource>
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

    public static BookingBookingSource FromValue(string value) => FromValueCore(value);
}
