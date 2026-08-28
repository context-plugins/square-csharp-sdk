using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Request object for linking a bank account to a Square account
/// </summary>
public record CreateBankAccountRequest
{
    /// <summary>
    /// Unique ID. For more information, see the
    /// <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the source that represents the bank account information to be stored. This field
    /// accepts the payment token created by WebSDK
    /// </summary>
    [JsonPropertyName("source_id")]
    public required string SourceId { get; init; }

    /// <summary>
    /// The ID of the customer associated with the bank account to be stored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
