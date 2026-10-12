using Square.Models;

namespace Square.Requests.CustomerCustomAttributes;

/// <summary>
/// The inputs of the CreateCustomerCustomAttributeDefinition operation.
/// </summary>
public sealed record CreateCustomerCustomAttributeDefinitionOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateCustomerCustomAttributeDefinitionRequest Body { get; init; }
}
