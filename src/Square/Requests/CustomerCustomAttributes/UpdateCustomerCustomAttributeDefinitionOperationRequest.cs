using Square.Models;

namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the UpdateCustomerCustomAttributeDefinition operation.
/// </summary>
public sealed record UpdateCustomerCustomAttributeDefinitionOperationRequest
{
    /// <summary>
    /// The key of the custom attribute definition to update.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateCustomerCustomAttributeDefinitionRequest Body { get; init; }
}
