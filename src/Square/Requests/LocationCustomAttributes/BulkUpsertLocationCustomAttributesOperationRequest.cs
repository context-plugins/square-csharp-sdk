using Square.Models;

namespace Square.Requests.LocationCustomAttributes;

/// <summary>
/// The inputs of the BulkUpsertLocationCustomAttributes operation.
/// </summary>
public sealed record BulkUpsertLocationCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpsertLocationCustomAttributesRequest Body { get; init; }
}
