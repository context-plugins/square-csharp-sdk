using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Policies for accepting bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessBookingProfileBookingPolicy>))]
public sealed record BusinessBookingProfileBookingPolicy : StringEnum<BusinessBookingProfileBookingPolicy>
{
    private BusinessBookingProfileBookingPolicy(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller accepts all booking requests automatically.
    /// </summary>
    public static readonly BusinessBookingProfileBookingPolicy AcceptAll = new("ACCEPT_ALL");

    /// <summary>
    /// The seller must accept requests to complete bookings.
    /// </summary>
    public static readonly BusinessBookingProfileBookingPolicy RequiresAcceptance = new("REQUIRES_ACCEPTANCE");

    public static BusinessBookingProfileBookingPolicy FromValue(string value) => FromValueCore(value);
}
