using Square.Models;

namespace Square.Requests.OrderCustomAttributes;

/// <summary>
/// The inputs of the UpsertOrderCustomAttribute operation.
/// </summary>
public sealed record UpsertOrderCustomAttributeOperationRequest
{
    /// <summary>
    /// The ID of the target <see href="entity:Order">order</see>.
    /// </summary>
    public required string OrderId { get; init; }

    /// <summary>
    /// The key of the custom attribute to create or update.  This key must match the key
    /// of an existing custom attribute definition.
    /// </summary>
    public required string CustomAttributeKey { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpsertOrderCustomAttributeRequest Body { get; init; }
}
