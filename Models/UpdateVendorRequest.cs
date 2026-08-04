using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Vendors-UpdateVendor">UpdateVendor</see>.
/// </summary>
public record UpdateVendorRequest
{
    /// <summary>
    /// A client-supplied, universally unique identifier (UUID) for the
    /// request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see> in the
    /// <see href="https://developer.squareup.com/docs/buildbasics">API Development 101</see> section for more
    /// information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a supplier to a seller.
    /// </summary>
    [JsonPropertyName("vendor")]
    public required Vendor Vendor { get; init; }
}
