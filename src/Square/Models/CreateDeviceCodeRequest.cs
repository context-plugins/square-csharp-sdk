using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CreateDeviceCodeRequest
{
    /// <summary>
    /// A unique string that identifies this CreateDeviceCode request. Keys can
    /// be any valid string but must be unique for every CreateDeviceCode request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    [JsonPropertyName("device_code")]
    public required DeviceCode DeviceCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
