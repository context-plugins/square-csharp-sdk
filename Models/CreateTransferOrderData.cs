using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Data for creating a new transfer order to move <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s
/// between <see href="entity:Location">Location</see>s. Used with the <see href="api-endpoint:TransferOrders-CreateTransferOrder">CreateTransferOrder</see>
/// endpoint.
/// </summary>
public record CreateTransferOrderData
{
    /// <summary>
    /// The source <see href="entity:Location">Location</see> that will send the items. Must be an active location
    /// in your Square account with sufficient inventory of the requested items.
    /// </summary>
    [JsonPropertyName("source_location_id")]
    [StringLength(64, MinimumLength = 1)]
    public required string SourceLocationId { get; init; }

    /// <summary>
    /// The destination <see href="entity:Location">Location</see> that will receive the items. Must be an active location
    /// in your Square account
    /// </summary>
    [JsonPropertyName("destination_location_id")]
    [StringLength(64, MinimumLength = 1)]
    public required string DestinationLocationId { get; init; }

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
    /// Optional shipment tracking number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_number")]
    [MaxLength(64)]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// ID of the <see href="entity:TeamMember">TeamMember</see> creating this transfer order. Used for tracking
    /// and auditing purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_by_team_member_id")]
    [MaxLength(64)]
    public string? CreatedByTeamMemberId { get; init; }

    /// <summary>
    /// List of <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s to transfer, including quantities
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_items")]
    public IReadOnlyList<CreateTransferOrderLineData?>? LineItems { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
