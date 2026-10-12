using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Vendors-BulkRetrieveVendors">BulkRetrieveVendors</see>.
/// </summary>
public record BulkRetrieveVendorsRequest
{
    /// <summary>
    /// IDs of the <see href="entity:Vendor">Vendor</see> objects to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor_ids")]
    public IReadOnlyList<string>? VendorIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
