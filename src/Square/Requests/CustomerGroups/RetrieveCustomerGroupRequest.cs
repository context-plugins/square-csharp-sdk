namespace Square.Requests.CustomerGroups;

/// <summary>
/// The inputs of the RetrieveCustomerGroup operation.
/// </summary>
public sealed record RetrieveCustomerGroupRequest
{
    /// <summary>
    /// The ID of the customer group to retrieve.
    /// </summary>
    public required string GroupId { get; init; }
}
