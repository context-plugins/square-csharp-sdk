using Square.Models;

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the BulkDeleteOrderCustomAttributes operation.
/// </summary>
public sealed record BulkDeleteOrderCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkDeleteOrderCustomAttributesRequest Body { get; init; }
}
