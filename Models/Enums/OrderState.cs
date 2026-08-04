using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The state of the order.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderState>))]
public sealed record OrderState : StringEnum<OrderState>
{
    private OrderState(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the order is open. Open orders can be updated.
    /// </summary>
    public static readonly OrderState Open = new("OPEN");

    /// <summary>
    /// Indicates that the order is completed. Completed orders are fully paid. This is a terminal state.
    /// </summary>
    public static readonly OrderState Completed = new("COMPLETED");

    /// <summary>
    /// Indicates that the order is canceled. Canceled orders are not paid. This is a terminal state.
    /// </summary>
    public static readonly OrderState Canceled = new("CANCELED");

    /// <summary>
    /// Indicates that the order is in a draft state. Draft orders can be updated,
    /// but cannot be paid or fulfilled.
    /// For more information, see <see href="https://developer.squareup.com/docs/orders-api/create-orders">Create Orders</see>.
    /// </summary>
    public static readonly OrderState Draft = new("DRAFT");

    public static OrderState FromValue(string value) => FromValueCore(value);
}
