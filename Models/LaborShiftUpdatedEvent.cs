using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Published when a <see href="entity:Shift">Shift</see> is updated.
/// <para>
/// Deprecated at Square API version 2025-05-21. Replaced by <c>labor.timecard.updated</c>.
/// </para>
/// </summary>
public record LaborShiftUpdatedEvent
{
    /// <summary>
    /// The ID of the merchant associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The type of event. For this event, the value is <c>labor.shift.updated</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The unique ID for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// The timestamp of when the event was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public LaborShiftUpdatedEventData? Data { get; init; }
}
