using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// An enum identifier of the device type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceAttributesDeviceType>))]
public sealed record DeviceAttributesDeviceType : StringEnum<DeviceAttributesDeviceType>
{
    private DeviceAttributesDeviceType(string value) : base(value)
    {
    }

    public static readonly DeviceAttributesDeviceType Terminal = new("TERMINAL");

    public static readonly DeviceAttributesDeviceType Handheld = new("HANDHELD");

    public static DeviceAttributesDeviceType FromValue(string value) => FromValueCore(value);
}
