using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListChannelsRequestConstants>))]
public sealed record ListChannelsRequestConstants : StringEnum<ListChannelsRequestConstants>
{
    private ListChannelsRequestConstants(string value) : base(value)
    {
    }

    public static readonly ListChannelsRequestConstants MaxPageSize = new("MAX_PAGE_SIZE");

    public static ListChannelsRequestConstants FromValue(string value) => FromValueCore(value);
}
