using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of a booking creator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingCreatorDetailsCreatorType>))]
public sealed record BookingCreatorDetailsCreatorType : StringEnum<BookingCreatorDetailsCreatorType>
{
    private BookingCreatorDetailsCreatorType(string value) : base(value)
    {
    }

    /// <summary>
    /// The creator is of the seller type.
    /// </summary>
    public static readonly BookingCreatorDetailsCreatorType TeamMember = new("TEAM_MEMBER");

    /// <summary>
    /// The creator is of the buyer type.
    /// </summary>
    public static readonly BookingCreatorDetailsCreatorType Customer = new("CUSTOMER");

    public static BookingCreatorDetailsCreatorType FromValue(string value) => FromValueCore(value);
}
