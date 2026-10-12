using Square.Models;

namespace Square.Requests.CustomerGroups;

/// <summary>
/// The inputs of the UpdateCustomerGroup operation.
/// </summary>
public sealed record UpdateCustomerGroupOperationRequest
{
    /// <summary>
    /// The ID of the customer group to update.
    /// </summary>
    public required string GroupId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateCustomerGroupRequest Body { get; init; }
}
