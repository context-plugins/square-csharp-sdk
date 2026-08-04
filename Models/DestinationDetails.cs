using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Details about a refund's destination.
/// </summary>
public record DestinationDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_details")]
    public DestinationDetailsCardRefundDetails? CardDetails { get; init; }

    /// <summary>
    /// Stores details about a cash refund. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_details")]
    public DestinationDetailsCashRefundDetails? CashDetails { get; init; }

    /// <summary>
    /// Stores details about an external refund. Contains only non-confidential information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_details")]
    public DestinationDetailsExternalRefundDetails? ExternalDetails { get; init; }
}
