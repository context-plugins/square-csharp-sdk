using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:BookingCustomAttributes-BulkDeleteBookingCustomAttributes">BulkDeleteBookingCustomAttributes</see> request.
/// </summary>
public record BulkDeleteBookingCustomAttributesRequest
{
    /// <summary>
    /// A map containing 1 to 25 individual Delete requests. For each request, provide an
    /// arbitrary ID that is unique for this <c>BulkDeleteBookingCustomAttributes</c> request and the
    /// information needed to delete a custom attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BookingCustomAttributeDeleteRequest> Values { get; init; }
}
