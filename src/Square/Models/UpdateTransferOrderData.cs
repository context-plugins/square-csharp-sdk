using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Data model for updating a transfer order. All fields are optional.
/// </summary>
public record UpdateTransferOrderData
{
    /// <summary>
    /// The source <see href="entity:Location">Location</see> that will send the items. Must be an active location
    /// in your Square account with sufficient inventory of the requested items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_location_id")]
    [StringLength(64, MinimumLength = 1)]
    public string? SourceLocationId { get; init; }

    /// <summary>
    /// The destination <see href="entity:Location">Location</see> that will receive the items. Must be an active location
    /// in your Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination_location_id")]
    [StringLength(64, MinimumLength = 1)]
    public string? DestinationLocationId { get; init; }

    /// <summary>
    /// Expected transfer date in RFC 3339 format (e.g. "2023-10-01T12:00:00Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_at")]
    public string? ExpectedAt { get; init; }

    /// <summary>
    /// Optional notes about the transfer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    [MaxLength(4096)]
    public string? Notes { get; init; }

    /// <summary>
    /// Shipment tracking number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_number")]
    [MaxLength(64)]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// List of items being transferred
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_items")]
    public IReadOnlyList<UpdateTransferOrderLineData>? LineItems { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
