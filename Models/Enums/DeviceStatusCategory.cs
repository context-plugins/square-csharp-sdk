using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DeviceStatusCategory>))]
public sealed record DeviceStatusCategory : StringEnum<DeviceStatusCategory>
{
    private DeviceStatusCategory(string value) : base(value)
    {
    }

    public static readonly DeviceStatusCategory Available = new("AVAILABLE");

    public static readonly DeviceStatusCategory NeedsAttention = new("NEEDS_ATTENTION");

    public static readonly DeviceStatusCategory Offline = new("OFFLINE");

    public static DeviceStatusCategory FromValue(string value) => FromValueCore(value);
}
