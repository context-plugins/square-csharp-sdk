using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Fields that can be used for sorting <see href="entity:TransferOrder">TransferOrder</see>s in search results.
/// Used with <see href="api-endpoint:TransferOrders-SearchTransferOrders">SearchTransferOrders</see> to control
/// the order of returned results.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferOrderSortField>))]
public sealed record TransferOrderSortField : StringEnum<TransferOrderSortField>
{
    private TransferOrderSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Sort by creation date (created_at field). Useful for:
    /// - Finding newest transfers
    /// - Chronological order processing
    /// - Historical analysis
    /// - Auditing transfer patterns
    /// </summary>
    public static readonly TransferOrderSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// Sort by last update date (updated_at field). Useful for:
    /// - Finding recently modified transfers
    /// - Tracking status changes
    /// - Monitoring receiving progress
    /// - Synchronizing with external systems
    /// </summary>
    public static readonly TransferOrderSortField UpdatedAt = new("UPDATED_AT");

    public static TransferOrderSortField FromValue(string value) => FromValueCore(value);
}
