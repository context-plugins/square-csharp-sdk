using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Policies for accepting bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessBookingProfileBookingPolicy>))]
public sealed record BusinessBookingProfileBookingPolicy : OpenStringEnum<BusinessBookingProfileBookingPolicy>
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

    public TResult Match<TResult>(Func<TResult> onAcceptAll,
        Func<TResult> onRequiresAcceptance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AcceptAll => onAcceptAll(),
            _ when this == RequiresAcceptance => onRequiresAcceptance(),
            _ => otherwise(Value)
        };

    public void Match(Action onAcceptAll, Action onRequiresAcceptance, Action<string> otherwise)
    {
        if (this == AcceptAll) onAcceptAll();
        else if (this == RequiresAcceptance) onRequiresAcceptance();
        else otherwise(Value);
    }
}
