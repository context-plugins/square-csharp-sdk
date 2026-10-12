namespace Square.Requests.CustomerGroups;

/// <summary>
/// The inputs of the DeleteCustomerGroup operation.
/// </summary>
public sealed record DeleteCustomerGroupRequest
{
    /// <summary>
    /// The ID of the customer group to delete.
    /// </summary>
    public required string GroupId { get; init; }
}
