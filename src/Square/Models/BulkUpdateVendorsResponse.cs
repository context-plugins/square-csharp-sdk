using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Vendors-BulkUpdateVendors">BulkUpdateVendors</see>.
/// </summary>
public record BulkUpdateVendorsResponse
{
    /// <summary>
    /// Errors encountered when the request fails.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A set of <see href="entity:UpdateVendorResponse">UpdateVendorResponse</see> objects encapsulating successfully created <see href="entity:Vendor">Vendor</see>
    /// objects or error responses for failed attempts. The set is represented by a collection of <c>Vendor</c>-ID/<c>UpdateVendorResponse</c>-object or
    /// <c>Vendor</c>-ID/error-object pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, UpdateVendorResponse>? Responses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
