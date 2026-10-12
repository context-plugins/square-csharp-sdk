namespace Square.Requests.BookingCustomAttributes;

/// <summary>
/// The inputs of the DeleteBookingCustomAttributeDefinition operation.
/// </summary>
public sealed record DeleteBookingCustomAttributeDefinitionRequest
{
    /// <summary>
    /// The key of the custom attribute definition to delete.
    /// </summary>
    public required string Key { get; init; }
}
