using Square.Models;

namespace Square.Requests.BookingCustomAttributes;

/// <summary>
/// The inputs of the UpdateBookingCustomAttributeDefinition operation.
/// </summary>
public sealed record UpdateBookingCustomAttributeDefinitionOperationRequest
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
    public required UpdateBookingCustomAttributeDefinitionRequest Body { get; init; }
}
