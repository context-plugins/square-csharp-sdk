using Square.Models;

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the BulkUpsertOrderCustomAttributes operation.
/// </summary>
public sealed record BulkUpsertOrderCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpsertOrderCustomAttributesRequest Body { get; init; }
}
