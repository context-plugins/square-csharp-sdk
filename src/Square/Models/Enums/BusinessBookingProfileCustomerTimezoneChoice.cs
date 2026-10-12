using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Choices of customer-facing time zone used for bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessBookingProfileCustomerTimezoneChoice>))]
public sealed record BusinessBookingProfileCustomerTimezoneChoice : OpenStringEnum<BusinessBookingProfileCustomerTimezoneChoice>
{
    private BusinessBookingProfileCustomerTimezoneChoice(string value) : base(value)
    {
    }

    /// <summary>
    /// Use the time zone of the business location for bookings.
    /// </summary>
    public static readonly BusinessBookingProfileCustomerTimezoneChoice BusinessLocationTimezone = new(
        "BUSINESS_LOCATION_TIMEZONE");

    /// <summary>
    /// Use the customer-chosen time zone for bookings.
    /// </summary>
    public static readonly BusinessBookingProfileCustomerTimezoneChoice CustomerChoice = new("CUSTOMER_CHOICE");

    public TResult Match<TResult>(Func<TResult> onBusinessLocationTimezone,
        Func<TResult> onCustomerChoice,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessLocationTimezone => onBusinessLocationTimezone(),
            _ when this == CustomerChoice => onCustomerChoice(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessLocationTimezone, Action onCustomerChoice, Action<string> otherwise)
    {
        if (this == BusinessLocationTimezone) onBusinessLocationTimezone();
        else if (this == CustomerChoice) onCustomerChoice();
        else otherwise(Value);
    }
}
