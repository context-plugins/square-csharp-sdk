using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:BookingCustomAttributes-DeleteBookingCustomAttributeDefinition">DeleteBookingCustomAttributeDefinition</see> response
/// containing error messages when errors occurred during the request. The successful response does not contain any payload.
/// </summary>
public record DeleteBookingCustomAttributeDefinitionResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
