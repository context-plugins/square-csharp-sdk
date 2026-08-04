using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Information about fulfillment updates.
/// </summary>
public record OrderFulfillmentUpdatedUpdate
{
    /// <summary>
    /// A unique ID that identifies the fulfillment only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_uid")]
    public string? FulfillmentUid { get; init; }

    /// <summary>
    /// The current state of this fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("old_state")]
    public FulfillmentState? OldState { get; init; }

    /// <summary>
    /// The current state of this fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_state")]
    public FulfillmentState? NewState { get; init; }
}
