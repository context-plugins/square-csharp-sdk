using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Response for receiving items for a transfer order
/// </summary>
public record ReceiveTransferOrderResponse
{
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_order")]
    public TransferOrder? TransferOrder { get; init; }

    /// <summary>
    /// Any errors that occurred during the request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
