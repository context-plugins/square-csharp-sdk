using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of location where service is provided.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsBookingLocationType>))]
public sealed record BusinessAppointmentSettingsBookingLocationType : OpenStringEnum<BusinessAppointmentSettingsBookingLocationType>
{
    private BusinessAppointmentSettingsBookingLocationType(string value) : base(value)
    {
    }

    /// <summary>
    /// The service is provided at a seller location.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType BusinessLocation = new("BUSINESS_LOCATION");

    /// <summary>
    /// The service is provided at a customer location.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType CustomerLocation = new("CUSTOMER_LOCATION");

    /// <summary>
    /// The service is provided over the phone.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType Phone = new("PHONE");

    public TResult Match<TResult>(Func<TResult> onBusinessLocation,
        Func<TResult> onCustomerLocation,
        Func<TResult> onPhone,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessLocation => onBusinessLocation(),
            _ when this == CustomerLocation => onCustomerLocation(),
            _ when this == Phone => onPhone(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessLocation, Action onCustomerLocation, Action onPhone, Action<string> otherwise)
    {
        if (this == BusinessLocation) onBusinessLocation();
        else if (this == CustomerLocation) onCustomerLocation();
        else if (this == Phone) onPhone();
        else otherwise(Value);
    }
}
