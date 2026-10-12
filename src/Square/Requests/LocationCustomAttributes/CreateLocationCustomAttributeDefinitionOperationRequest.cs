using Square.Models;

namespace Square.Requests.LocationCustomAttributes;

/// <summary>
/// The inputs of the CreateLocationCustomAttributeDefinition operation.
/// </summary>
public sealed record CreateLocationCustomAttributeDefinitionOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateLocationCustomAttributeDefinitionRequest Body { get; init; }
}
