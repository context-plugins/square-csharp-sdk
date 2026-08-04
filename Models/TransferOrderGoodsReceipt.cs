using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

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
public record TransferOrderGoodsReceipt
{
    /// <summary>
    /// Line items being received. Each line item specifies:
    /// - The item being received
    /// - Quantity received in good condition
    /// - Quantity received damaged
    /// - Quantity canceled
    /// <para>
    /// Constraints:
    /// - Must include at least one line item
    /// - Maximum of 1000 line items per receipt
    /// - Each line item must reference a valid item from the transfer order
    /// - Total of received, damaged, and canceled quantities cannot exceed ordered quantity
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_items")]
    public IReadOnlyList<TransferOrderGoodsReceiptLineItem?>? LineItems { get; init; }
}
