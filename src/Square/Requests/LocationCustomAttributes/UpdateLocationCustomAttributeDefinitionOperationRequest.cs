using Square.Models;

namespace Square.Requests.LocationCustomAttributes;

/// <summary>
/// The inputs of the UpdateLocationCustomAttributeDefinition operation.
/// </summary>
public sealed record UpdateLocationCustomAttributeDefinitionOperationRequest
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
    public required UpdateLocationCustomAttributeDefinitionRequest Body { get; init; }
}
