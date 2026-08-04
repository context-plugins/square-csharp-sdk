using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A request to create a new <c>BreakType</c>.
/// </summary>
public record CreateBreakTypeRequest
{
    /// <summary>
    /// A unique string value to ensure the idempotency of the operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// A template for a type of <see href="entity:Break">break</see> that can be added to a
    /// <see href="entity:Timecard">timecard</see>, including the expected duration and paid status.
    /// </summary>
    [JsonPropertyName("break_type")]
    public required BreakType BreakType { get; init; }
}
