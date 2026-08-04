using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Vendors-UpdateVendor">UpdateVendor</see>.
/// </summary>
public record UpdateVendorResponse
{
    /// <summary>
    /// Errors occurred when the request fails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a supplier to a seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor")]
    public Vendor? Vendor { get; init; }
}
