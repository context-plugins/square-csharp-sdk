using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record VendorUpdatedEventObject
{
    /// <summary>
    /// The operation that can be performed against a vendor to cause the event to be published.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("operation")]
    public VendorUpdatedEventObjectOperation? Operation { get; init; }

    /// <summary>
    /// Represents a supplier to a seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor")]
    public Vendor? Vendor { get; init; }
}
