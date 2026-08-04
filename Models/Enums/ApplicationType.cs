using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ApplicationType>))]
public sealed record ApplicationType : StringEnum<ApplicationType>
{
    private ApplicationType(string value) : base(value)
    {
    }

    public static readonly ApplicationType TerminalApi = new("TERMINAL_API");

    public static ApplicationType FromValue(string value) => FromValueCore(value);
}
