using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// V1UpdateOrderRequest
/// </summary>
public record V1UpdateOrderRequest
{
    [JsonPropertyName("action")]
    public required V1UpdateOrderRequestAction Action { get; init; }

    /// <summary>
    /// The tracking number of the shipment associated with the order. Only valid if action is COMPLETE.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipped_tracking_number")]
    public string? ShippedTrackingNumber { get; init; }

    /// <summary>
    /// A merchant-specified note about the completion of the order. Only valid if action is COMPLETE.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_note")]
    public string? CompletedNote { get; init; }

    /// <summary>
    /// A merchant-specified note about the refunding of the order. Only valid if action is REFUND.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_note")]
    public string? RefundedNote { get; init; }

    /// <summary>
    /// A merchant-specified note about the canceling of the order. Only valid if action is CANCEL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_note")]
    public string? CanceledNote { get; init; }
}
