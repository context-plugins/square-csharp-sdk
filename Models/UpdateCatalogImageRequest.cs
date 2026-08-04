using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateCatalogImageRequest
{
    /// <summary>
    /// A unique string that identifies this UpdateCatalogImage request.
    /// Keys can be any valid string but must be unique for every UpdateCatalogImage request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
