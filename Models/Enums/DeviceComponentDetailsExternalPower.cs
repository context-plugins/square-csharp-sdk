using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum for ExternalPower.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceComponentDetailsExternalPower>))]
public sealed record DeviceComponentDetailsExternalPower : StringEnum<DeviceComponentDetailsExternalPower>
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

    public static DeviceComponentDetailsExternalPower FromValue(string value) => FromValueCore(value);
}
