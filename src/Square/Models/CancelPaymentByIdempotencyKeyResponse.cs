using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the response returned by
/// <see href="api-endpoint:Payments-CancelPaymentByIdempotencyKey">CancelPaymentByIdempotencyKey</see>.
/// On success, <c>errors</c> is empty.
/// </summary>
public record CancelPaymentByIdempotencyKeyResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
