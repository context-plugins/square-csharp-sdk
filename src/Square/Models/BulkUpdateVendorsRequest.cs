using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Vendors-BulkUpdateVendors">BulkUpdateVendors</see>.
/// </summary>
public record BulkUpdateVendorsRequest
{
    /// <summary>
    /// A set of <see href="entity:UpdateVendorRequest">UpdateVendorRequest</see> objects encapsulating to-be-updated <see href="entity:Vendor">Vendor</see>
    /// objects. The set is represented by  a collection of <c>Vendor</c>-ID/<c>UpdateVendorRequest</c>-object pairs.
    /// </summary>
    [JsonPropertyName("vendors")]
    public required IReadOnlyDictionary<string, UpdateVendorRequest> Vendors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
