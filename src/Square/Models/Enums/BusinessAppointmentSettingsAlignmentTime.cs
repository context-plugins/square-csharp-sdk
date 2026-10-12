using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Time units of a service duration for bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsAlignmentTime>))]
public sealed record BusinessAppointmentSettingsAlignmentTime : OpenStringEnum<BusinessAppointmentSettingsAlignmentTime>
{
    private BusinessAppointmentSettingsAlignmentTime(string value) : base(value)
    {
    }

    /// <summary>
    /// The service duration unit is one visit of a fixed time interval specified by the seller.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime ServiceDuration = new("SERVICE_DURATION");

    /// <summary>
    /// The service duration unit is a 15-minute interval. Bookings can be scheduled every quarter hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime QuarterHourly = new("QUARTER_HOURLY");

    /// <summary>
    /// The service duration unit is a 30-minute interval. Bookings can be scheduled every half hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime HalfHourly = new("HALF_HOURLY");

    /// <summary>
    /// The service duration unit is a 60-minute interval. Bookings can be scheduled every hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime Hourly = new("HOURLY");

    public TResult Match<TResult>(Func<TResult> onServiceDuration,
        Func<TResult> onQuarterHourly,
        Func<TResult> onHalfHourly,
        Func<TResult> onHourly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ServiceDuration => onServiceDuration(),
            _ when this == QuarterHourly => onQuarterHourly(),
            _ when this == HalfHourly => onHalfHourly(),
            _ when this == Hourly => onHourly(),
            _ => otherwise(Value)
        };

    public void Match(Action onServiceDuration,
        Action onQuarterHourly,
        Action onHalfHourly,
        Action onHourly,
        Action<string> otherwise)
    {
        if (this == ServiceDuration) onServiceDuration();
        else if (this == QuarterHourly) onQuarterHourly();
        else if (this == HalfHourly) onHalfHourly();
        else if (this == Hourly) onHourly();
        else otherwise(Value);
    }
}
