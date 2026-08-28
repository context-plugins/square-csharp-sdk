using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// An item variation, representing a product for sale, in the Catalog object model. Each <see href="entity:CatalogItem">item</see> must have at least one
/// item variation and can have at most 250 item variations.
/// <para>
/// An item variation can be sellable, stockable, or both if it has a unit of measure for its count for the sold number of the variation, the stocked
/// number of the variation, or both. For example, when a variation representing wine is stocked and sold by the bottle, the variation is both
/// stockable and sellable. But when a variation of the wine is sold by the glass, the sold units cannot be used as a measure of the stocked units. This by-the-glass
/// variation is sellable, but not stockable. To accurately keep track of the wine's inventory count at any time, the sellable count must be
/// converted to stockable count. Typically, the seller defines this unit conversion. For example, 1 bottle equals 5 glasses. The Square API exposes
/// the <c>stockable_conversion</c> property on the variation to specify the conversion. Thus, when two glasses of the wine are sold, the sellable count
/// decreases by 2, and the stockable count automatically decreases by 0.4 bottle according to the conversion.
/// </para>
/// </summary>
public record CatalogItemVariation
{
    /// <summary>
    /// The ID of the <c>CatalogItem</c> associated with this item variation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// The item variation's name. This is a searchable attribute for use in applicable query filters.
    /// <para>
    /// Its value has a maximum length of 255 Unicode code points. However, when the parent <see href="entity:CatalogItem">item</see>
    /// uses <see href="entity:CatalogItemOption">item options</see>, this attribute is auto-generated, read-only, and can be
    /// longer than 255 Unicode code points.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The item variation's SKU, if any. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }

    /// <summary>
    /// The universal product code (UPC) of the item variation, if any. This is a searchable attribute for use in applicable query filters.
    /// <para>
    /// The value of this attribute should be a number of 12-14 digits long.  This restriction is enforced on the Square Seller Dashboard,
    /// Square Point of Sale or Retail Point of Sale apps, where this attribute shows in the GTIN field. If a non-compliant UPC value is assigned
    /// to this attribute using the API, the value is not editable on the Seller Dashboard, Square Point of Sale or Retail Point of Sale apps
    /// unless it is updated to fit the expected format.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upc")]
    public string? Upc { get; init; }

    /// <summary>
    /// The order in which this item variation should be displayed. This value is read-only. On writes, the ordinal
    /// for each item variation within a parent <c>CatalogItem</c> is set according to the item variations's
    /// position. On reads, the value is not guaranteed to be sequential or unique.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// Indicates whether the price of a CatalogItemVariation should be entered manually at the time of sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_type")]
    public CatalogPricingType? PricingType { get; init; }

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
    /// Per-location price and inventory overrides.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_overrides")]
    public IReadOnlyList<ItemVariationLocationOverrides?>? LocationOverrides { get; init; }

    /// <summary>
    /// If <c>true</c>, inventory tracking is active for the variation at all locations by default.
    /// This value can be overridden for specific locations using <c>ItemVariationLocationOverrides.track_inventory</c>.
    /// If unset at both levels, inventory tracking is disabled.
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
    /// is <c>LOW_QUANTITY</c>, the variation displays an alert in the merchant dashboard. This value is always an integer.
    /// <para>
    /// Deprecated because this field has never been global.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_alert_threshold")]
    public long? InventoryAlertThreshold { get; init; }

    /// <summary>
    /// Arbitrary user metadata to associate with the item variation. This attribute value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_data")]
    [MaxLength(255)]
    public string? UserData { get; init; }

    /// <summary>
    /// If the <c>CatalogItem</c> that owns this item variation is of type
    /// <c>APPOINTMENTS_SERVICE</c>, then this is the duration of the service in milliseconds. For
    /// example, a 30 minute appointment would have the value <c>1800000</c>, which is equal to
    /// 30 (minutes) * 60 (seconds per minute) * 1000 (milliseconds per second).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_duration")]
    public long? ServiceDuration { get; init; }

    /// <summary>
    /// If the <c>CatalogItem</c> that owns this item variation is of type
    /// <c>APPOINTMENTS_SERVICE</c>, a bool representing whether this service is available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_for_booking")]
    public bool? AvailableForBooking { get; init; }

    /// <summary>
    /// List of item option values associated with this item variation. Listed
    /// in the same order as the item options of the parent item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_values")]
    public IReadOnlyList<CatalogItemOptionValueForItemVariation?>? ItemOptionValues { get; init; }

    /// <summary>
    /// ID of the ‘CatalogMeasurementUnit’ that is used to measure the quantity
    /// sold of this item variation. If left unset, the item will be sold in
    /// whole quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit_id")]
    public string? MeasurementUnitId { get; init; }

    /// <summary>
    /// Whether this variation can be sold. The inventory count of a sellable variation indicates
    /// the number of units available for sale. When a variation is both stockable and sellable,
    /// its sellable inventory count can be smaller than or equal to its stockable count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sellable")]
    public bool? Sellable { get; init; }

    /// <summary>
    /// Whether stock is counted directly on this variation (TRUE) or only on its components (FALSE).
    /// When a variation is both stockable and sellable, the inventory count of a stockable variation keeps track of the number of units of this variation in stock
    /// and is not an indicator of the number of units of the variation that can be sold.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockable")]
    public bool? Stockable { get; init; }

    /// <summary>
    /// The IDs of images associated with this <c>CatalogItemVariation</c> instance.
    /// These images will be shown to customers in Square Online Store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_ids")]
    public IReadOnlyList<string?>? ImageIds { get; init; }

    /// <summary>
    /// Tokens of employees that can perform the service represented by this variation. Only valid for
    /// variations of type <c>APPOINTMENTS_SERVICE</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_ids")]
    public IReadOnlyList<string?>? TeamMemberIds { get; init; }

    /// <summary>
    /// Represents the rule of conversion between a stockable <see href="entity:CatalogItemVariation">CatalogItemVariation</see>
    /// and a non-stockable sell-by or receive-by <c>CatalogItemVariation</c> that
    /// share the same underlying stock.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockable_conversion")]
    public CatalogStockConversion? StockableConversion { get; init; }

    /// <summary>
    /// (Optional) Name that the restaurant wants to display to their kitchen workers
    /// instead of the customer-facing name.
    /// e.g., customer name might be "Mega-Jumbo Triplesized" and the
    /// kitchen name is "Large container"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kitchen_name")]
    public string? KitchenName { get; init; }

    /// <summary>
    /// Details of the vendor this product is purchased from.
    /// This field can be set only if the seller has an active subscription
    /// to either Square for Retail Premium or Square for Restaurants Premium.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor_information")]
    public IReadOnlyList<CatalogItemVariationVendorInformation?>? VendorInformation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
