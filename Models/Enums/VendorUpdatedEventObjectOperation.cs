using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The operation that can be performed against a vendor to cause the event to be published.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorUpdatedEventObjectOperation>))]
public sealed record VendorUpdatedEventObjectOperation : StringEnum<VendorUpdatedEventObjectOperation>
{
    private VendorUpdatedEventObjectOperation(string value) : base(value)
    {
    }

    public static readonly VendorUpdatedEventObjectOperation Updated = new("UPDATED");

    public static VendorUpdatedEventObjectOperation FromValue(string value) => FromValueCore(value);
}
