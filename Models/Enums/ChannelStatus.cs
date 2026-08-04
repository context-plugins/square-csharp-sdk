using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChannelStatus>))]
public sealed record ChannelStatus : StringEnum<ChannelStatus>
{
    private ChannelStatus(string value) : base(value)
    {
    }

    public static readonly ChannelStatus Active = new("ACTIVE");

    public static readonly ChannelStatus Inactive = new("INACTIVE");

    public static ChannelStatus FromValue(string value) => FromValueCore(value);
}
