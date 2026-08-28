using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a transfer order for moving <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s
/// between <see href="entity:Location">Location</see>s. Transfer orders track the entire lifecycle of an inventory
/// transfer, including:
/// - What items and quantities are being moved
/// - Source and destination locations
/// - Current <see href="entity:TransferOrderStatus">TransferOrderStatus</see>
/// - Shipping information and tracking
/// - Which <see href="entity:TeamMember">TeamMember</see> initiated the transfer
/// <para>
/// This object is commonly used to:
/// - Track <see href="entity:CatalogItemVariation">CatalogItemVariation</see> movements between <see href="entity:Location">Location</see>s
/// - Reconcile expected vs received quantities
/// - Monitor transfer progress and shipping status
/// - Audit inventory movement history
/// </para>
/// </summary>
public record TransferOrder
{
    /// <summary>
    /// Unique system-generated identifier for this transfer order. Use this ID for:
    /// - Retrieving transfer order details
    /// - Tracking status changes via webhooks
    /// - Linking transfers in external systems
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The source <see href="entity:Location">Location</see> sending the <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s.
    /// This location must:
    /// - Be active in your Square organization
    /// - Have sufficient inventory for the items being transferred
    /// - Not be the same as the destination location
    /// <para>
    /// This field is not updatable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_location_id")]
    public string? SourceLocationId { get; init; }

    /// <summary>
    /// The destination <see href="entity:Location">Location</see> receiving the <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s.
    /// This location must:
    /// - Be active in your Square organization
    /// - Not be the same as the source location
    /// <para>
    /// This field is not updatable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination_location_id")]
    public string? DestinationLocationId { get; init; }

    /// <summary>
    /// Status values for transfer orders. Represents the current state of a
    /// <see href="entity:TransferOrder">TransferOrder</see> in its lifecycle from creation to completion.
    /// Each status determines what actions are available and how inventory is affected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TransferOrderStatus? Status { get; init; }

    /// <summary>
    /// Timestamp when the transfer order was created, in RFC 3339 format.
    /// Used for:
    /// - Auditing transfer history
    /// - Tracking order age
    /// - Reporting and analytics
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the transfer order was last updated, in RFC 3339 format.
    /// Updated when:
    /// - Order status changes
    /// - Items are received
    /// - Notes or metadata are modified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Expected transfer completion date, in RFC 3339 format.
    /// Used for:
    /// - Planning inventory availability
    /// - Scheduling receiving staff
    /// - Monitoring transfer timeliness
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_at")]
    public string? ExpectedAt { get; init; }

    /// <summary>
    /// Timestamp when the transfer order was completed or canceled, in RFC 3339 format (e.g. "2023-10-01T12:00:00Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_at")]
    public string? CompletedAt { get; init; }

    /// <summary>
    /// Optional notes about the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    /// <summary>
    /// Shipment tracking number for monitoring transfer progress.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_number")]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// ID of the <see href="entity:TeamMember">TeamMember</see> who created this transfer order. This field is not writeable by the Connect V2 API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_by_team_member_id")]
    public string? CreatedByTeamMemberId { get; init; }

    /// <summary>
    /// List of <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s being transferred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_items")]
    public IReadOnlyList<TransferOrderLine?>? LineItems { get; init; }

    /// <summary>
    /// Version for optimistic concurrency control. This is a monotonically increasing integer
    /// that changes whenever the transfer order is modified. Use this when calling
    /// <see href="api-endpoint:TransferOrders-UpdateTransferOrder">UpdateTransferOrder</see> and other endpoints to ensure you're
    /// not overwriting concurrent changes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
