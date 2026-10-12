using Square.Models;

namespace Square.Requests.MerchantCustomAttributes;

/// <summary>
/// The inputs of the UpsertMerchantCustomAttribute operation.
/// </summary>
public sealed record UpsertMerchantCustomAttributeOperationRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Merchant">merchant</see>.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The key of the custom attribute to create or update. This key must match the <c>key</c> of a
    /// custom attribute definition in the Square seller account. If the requesting application is not
    /// the definition owner, you must use the qualified key.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpsertMerchantCustomAttributeRequest Body { get; init; }
}
