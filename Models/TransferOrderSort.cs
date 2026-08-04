using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Sort configuration for search results
/// </summary>
public record TransferOrderSort
{
    /// <summary>
    /// Fields that can be used for sorting <see href="entity:TransferOrder">TransferOrder</see>s in search results.
    /// Used with <see href="api-endpoint:TransferOrders-SearchTransferOrders">SearchTransferOrders</see> to control
    /// the order of returned results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public TransferOrderSortField? Field { get; init; }

    /// <summary>
    /// The order (e.g., chronological or alphabetical) in which results from a request are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public SortOrder? Order { get; init; }
}
