using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum for ExternalPower.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceComponentDetailsExternalPower>))]
public sealed record DeviceComponentDetailsExternalPower : OpenStringEnum<DeviceComponentDetailsExternalPower>
{
    private DeviceComponentDetailsExternalPower(string value) : base(value)
    {
    }

    /// <summary>
    /// Plugged in and charging.
    /// </summary>
    public static readonly DeviceComponentDetailsExternalPower AvailableCharging = new("AVAILABLE_CHARGING");

    /// <summary>
    /// Fully charged.
    /// </summary>
    public static readonly DeviceComponentDetailsExternalPower AvailableNotInUse = new("AVAILABLE_NOT_IN_USE");

    /// <summary>
    /// On battery power.
    /// </summary>
    public static readonly DeviceComponentDetailsExternalPower Unavailable = new("UNAVAILABLE");

    /// <summary>
    /// Not providing enough power for the device.
    /// </summary>
    public static readonly DeviceComponentDetailsExternalPower AvailableInsufficient = new("AVAILABLE_INSUFFICIENT");

    public TResult Match<TResult>(Func<TResult> onAvailableCharging,
        Func<TResult> onAvailableNotInUse,
        Func<TResult> onUnavailable,
        Func<TResult> onAvailableInsufficient,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AvailableCharging => onAvailableCharging(),
            _ when this == AvailableNotInUse => onAvailableNotInUse(),
            _ when this == Unavailable => onUnavailable(),
            _ when this == AvailableInsufficient => onAvailableInsufficient(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailableCharging,
        Action onAvailableNotInUse,
        Action onUnavailable,
        Action onAvailableInsufficient,
        Action<string> otherwise)
    {
        if (this == AvailableCharging) onAvailableCharging();
        else if (this == AvailableNotInUse) onAvailableNotInUse();
        else if (this == Unavailable) onUnavailable();
        else if (this == AvailableInsufficient) onAvailableInsufficient();
        else otherwise(Value);
    }
}
