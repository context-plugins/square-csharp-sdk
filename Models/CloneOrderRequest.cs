using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in requests to the
/// <see href="api-endpoint:Orders-CloneOrder">CloneOrder</see> endpoint.
/// </summary>
public record CloneOrderRequest
{
    /// <summary>
    /// The ID of the order to clone.
    /// </summary>
    [JsonPropertyName("order_id")]
    public required string OrderId { get; init; }

    /// <summary>
    /// An optional order version for concurrency protection.
    /// <para>
    /// If a version is provided, it must match the latest stored version of the order to clone.
    /// If a version is not provided, the API clones the latest version.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// A value you specify that uniquely identifies this clone request.
    /// <para>
    /// If you are unsure whether a particular order was cloned successfully,
    /// you can reattempt the call with the same idempotency key without
    /// worrying about creating duplicate cloned orders.
    /// The originally cloned order is returned.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    public string? IdempotencyKey { get; init; }
}
