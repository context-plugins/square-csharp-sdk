using Square.Models;

namespace Square.Requests.CustomerGroups;

/// <summary>
/// The inputs of the CreateCustomerGroup operation.
/// </summary>
public sealed record CreateCustomerGroupOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateCustomerGroupRequest Body { get; init; }
}
