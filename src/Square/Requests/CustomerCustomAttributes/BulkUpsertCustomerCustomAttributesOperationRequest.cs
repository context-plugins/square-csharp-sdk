using Square.Models;

namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the BulkUpsertCustomerCustomAttributes operation.
/// </summary>
public sealed record BulkUpsertCustomerCustomAttributesOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkUpsertCustomerCustomAttributesRequest Body { get; init; }
}
