using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Request to record receipt of items for a transfer order
/// </summary>
public record ReceiveTransferOrderRequest
{
    /// <summary>
    /// A unique key to make this request idempotent
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The goods receipt details for a transfer order. This object represents a single receipt
    /// of goods against a transfer order, tracking:
    /// <list type="bullet">
    ///   <item><description>Which <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s were received</description></item>
    ///   <item><description>Quantities received in good condition</description></item>
    ///   <item><description>Quantities damaged during transit/handling</description></item>
    ///   <item><description>Quantities canceled during receipt</description></item>
    /// </list>
    /// <para>
    /// Multiple goods receipts can be created for a single transfer order to handle:
    /// - Partial deliveries
    /// - Multiple shipments
    /// - Split receipts across different dates
    /// - Cancellations of specific quantities
    /// </para>
    /// <para>
    /// Each receipt automatically:
    /// - Updates the transfer order status
    /// - Adjusts received quantities
    /// - Updates inventory levels at both source and destination <see href="entity:Location">Location</see>s
    /// </para>
    /// </summary>
    [JsonPropertyName("receipt")]
    public required TransferOrderGoodsReceipt Receipt { get; init; }

    /// <summary>
    /// Version for optimistic concurrency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }
}
