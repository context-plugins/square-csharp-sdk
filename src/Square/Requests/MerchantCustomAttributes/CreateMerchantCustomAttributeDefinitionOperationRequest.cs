using Square.Models;

namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the CreateMerchantCustomAttributeDefinition operation.
/// </summary>
public sealed record CreateMerchantCustomAttributeDefinitionOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateMerchantCustomAttributeDefinitionRequest Body { get; init; }
}
