using Square.Models;

namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the BulkUpsertMerchantCustomAttributes operation.
/// </summary>
public sealed record BulkUpsertMerchantCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpsertMerchantCustomAttributesRequest Body { get; init; }
}
