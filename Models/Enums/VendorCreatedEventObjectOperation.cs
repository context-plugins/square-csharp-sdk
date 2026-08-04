using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The operation that can be performed against a vendor to cause the event to be published.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorCreatedEventObjectOperation>))]
public sealed record VendorCreatedEventObjectOperation : StringEnum<VendorCreatedEventObjectOperation>
{
    private VendorCreatedEventObjectOperation(string value) : base(value)
    {
    }

    public static readonly VendorCreatedEventObjectOperation Created = new("CREATED");

    public static VendorCreatedEventObjectOperation FromValue(string value) => FromValueCore(value);
}
