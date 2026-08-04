using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an input to a call to <see href="api-endpoint:Vendors-CreateVendor">CreateVendor</see>.
/// </summary>
public record CreateVendorRequest
{
    /// <summary>
    /// A client-supplied, universally unique identifier (UUID) to make this <see href="api-endpoint:Vendors-CreateVendor">CreateVendor</see> call idempotent.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see> in the
    /// <see href="https://developer.squareup.com/docs/buildbasics">API Development 101</see> section for more
    /// information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a supplier to a seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor")]
    public Vendor? Vendor { get; init; }
}
