using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the brand for a co-branded card.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardCoBrand>))]
public sealed record CardCoBrand : StringEnum<CardCoBrand>
{
    private CardCoBrand(string value) : base(value)
    {
    }

    public static readonly CardCoBrand Unknown = new("UNKNOWN");

    public static readonly CardCoBrand Afterpay = new("AFTERPAY");

    public static readonly CardCoBrand Clearpay = new("CLEARPAY");

    public static CardCoBrand FromValue(string value) => FromValueCore(value);
}
