using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Price and inventory alerting overrides for a <c>CatalogItemVariation</c> at a specific <c>Location</c>.
/// </summary>
public record ItemVariationLocationOverrides
{
    /// <summary>
    /// The ID of the <c>Location</c>. This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_money")]
    public Money? PriceMoney { get; init; }

    /// <summary>
    /// Indicates whether the price of a CatalogItemVariation should be entered manually at the time of sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_type")]
    public CatalogPricingType? PricingType { get; init; }

    /// <summary>
    /// Indicates whether inventory tracking is active for the <c>CatalogItemVariation</c> at this <c>Location</c>.
    /// When set, this value explicitly overrides the global <c>track_inventory</c> setting. When unset, the location
    /// should use the global value. If both global and location-level values are unset, inventory tracking is disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("track_inventory")]
    public bool? TrackInventory { get; init; }

    /// <summary>
    /// Indicates whether Square should alert the merchant when the inventory quantity of a CatalogItemVariation is low.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_alert_type")]
    public InventoryAlertType? InventoryAlertType { get; init; }

    /// <summary>
    /// If the inventory quantity for the variation is less than or equal to this value and <c>inventory_alert_type</c>
    /// is <c>LOW_QUANTITY</c>, the variation displays an alert in the merchant dashboard.
    /// <para>
    /// This value is always an integer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_alert_threshold")]
    public long? InventoryAlertThreshold { get; init; }

    /// <summary>
    /// Indicates whether the overridden item variation is sold out at the specified location.
    /// <para>
    /// When inventory tracking is enabled on the item variation either globally or at the specified location,
    /// the item variation is automatically marked as sold out when its inventory count reaches zero. The seller
    /// can manually set the item variation as sold out even when the inventory count is greater than zero.
    /// Attempts by an application to set this attribute are ignored. Regardless how the sold-out status is set,
    /// applications should treat its inventory count as zero when this attribute value is <c>true</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sold_out")]
    public bool? SoldOut { get; init; }

    /// <summary>
    /// The seller-assigned timestamp, of the RFC 3339 format, to indicate when this sold-out variation
    /// becomes available again at the specified location. Attempts by an application to set this attribute are ignored.
    /// When the current time is later than this attribute value, the affected item variation is no longer sold out.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sold_out_valid_until")]
    public string? SoldOutValidUntil { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
