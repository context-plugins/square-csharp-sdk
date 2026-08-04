using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Vendors-BulkRetrieveVendors">BulkRetrieveVendors</see>.
/// </summary>
public record BulkRetrieveVendorsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The set of <see href="entity:RetrieveVendorResponse">RetrieveVendorResponse</see> objects encapsulating successfully retrieved <see href="entity:Vendor">Vendor</see>
    /// objects or error responses for failed attempts. The set is represented by
    /// a collection of <c>Vendor</c>-ID/<c>Vendor</c>-object or <c>Vendor</c>-ID/error-object pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, RetrieveVendorResponse>? Responses { get; init; }
}
