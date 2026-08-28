using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Vendors-BulkCreateVendors">BulkCreateVendors</see>.
/// </summary>
public record BulkCreateVendorsRequest
{
    /// <summary>
    /// Specifies a set of new <see href="entity:Vendor">Vendor</see> objects as represented by a collection of idempotency-key/<c>Vendor</c>-object pairs.
    /// </summary>
    [JsonPropertyName("vendors")]
    public required IReadOnlyDictionary<string, Vendor> Vendors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
