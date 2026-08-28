using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record TransferOrderCreatedEventObject
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
