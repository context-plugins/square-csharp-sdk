using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a response for an individual upsert request in a <see href="api-endpoint:BookingCustomAttributes-BulkUpsertBookingCustomAttributes">BulkUpsertBookingCustomAttributes</see> operation.
/// </summary>
public record BookingCustomAttributeUpsertResponse
{
    /// <summary>
    /// The ID of the <see href="entity:Booking">booking</see> associated with the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_id")]
    public string? BookingId { get; init; }

    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute")]
    public CustomAttribute? CustomAttribute { get; init; }

    /// <summary>
    /// Any errors that occurred while processing the individual request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
