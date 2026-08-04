using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Describes the input type of the data.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DataCollectionOptionsInputType>))]
public sealed record DataCollectionOptionsInputType : StringEnum<DataCollectionOptionsInputType>
{
    private DataCollectionOptionsInputType(string value) : base(value)
    {
    }

    /// <summary>
    /// This value is used to represent an input text that contains a email validation on the
    /// client.
    /// </summary>
    public static readonly DataCollectionOptionsInputType Email = new("EMAIL");

    /// <summary>
    /// This value is used to represent an input text that contains a phone number validation on
    /// the client.
    /// </summary>
    public static readonly DataCollectionOptionsInputType PhoneNumber = new("PHONE_NUMBER");

    public static DataCollectionOptionsInputType FromValue(string value) => FromValueCore(value);
}
