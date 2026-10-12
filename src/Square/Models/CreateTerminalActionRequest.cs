using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CreateTerminalActionRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateAction</c> request. Keys can be any valid string
    /// but must be unique for every <c>CreateAction</c> request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency keys</see> for more
    /// information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(64, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents an action processed by the Square Terminal.
    /// </summary>
    [JsonPropertyName("action")]
    public required TerminalAction Action { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
