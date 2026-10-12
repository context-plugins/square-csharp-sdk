using Square.Models;

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the UpdateOrderCustomAttributeDefinition operation.
/// </summary>
public sealed record UpdateOrderCustomAttributeDefinitionOperationRequest
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
    public required UpdateOrderCustomAttributeDefinitionRequest Body { get; init; }
}
