using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an output from a call to <see href="api-endpoint:Vendors-BulkCreateVendors">BulkCreateVendors</see>.
/// </summary>
public record BulkCreateVendorsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A set of <see href="entity:CreateVendorResponse">CreateVendorResponse</see> objects encapsulating successfully created <see href="entity:Vendor">Vendor</see>
    /// objects or error responses for failed attempts. The set is represented by
    /// a collection of idempotency-key/<c>Vendor</c>-object or idempotency-key/error-object pairs. The idempotency keys correspond to those specified
    /// in the input.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, CreateVendorResponse>? Responses { get; init; }
}
