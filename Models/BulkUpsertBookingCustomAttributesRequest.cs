using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:BookingCustomAttributes-BulkUpsertBookingCustomAttributes">BulkUpsertBookingCustomAttributes</see> request.
/// </summary>
public record BulkUpsertBookingCustomAttributesRequest
{
    /// <summary>
    /// A map containing 1 to 25 individual upsert requests. For each request, provide an
    /// arbitrary ID that is unique for this <c>BulkUpsertBookingCustomAttributes</c> request and the
    /// information needed to create or update a custom attribute.
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, BookingCustomAttributeUpsertRequest> Values { get; init; }
}
