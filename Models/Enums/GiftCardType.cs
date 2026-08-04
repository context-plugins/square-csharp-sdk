using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the gift card type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardType>))]
public sealed record GiftCardType : StringEnum<GiftCardType>
{
    private GiftCardType(string value) : base(value)
    {
    }

    /// <summary>
    /// A plastic gift card.
    /// </summary>
    public static readonly GiftCardType Physical = new("PHYSICAL");

    /// <summary>
    /// A digital gift card.
    /// </summary>
    public static readonly GiftCardType Digital = new("DIGITAL");

    public static GiftCardType FromValue(string value) => FromValueCore(value);
}
