using Square.Models;

namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the UpdateMerchantCustomAttributeDefinition operation.
/// </summary>
public sealed record UpdateMerchantCustomAttributeDefinitionOperationRequest
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
    public required UpdateMerchantCustomAttributeDefinitionRequest Body { get; init; }
}
