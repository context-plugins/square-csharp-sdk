using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Information about the vendor of an item variation.
/// </summary>
public record CatalogItemVariationVendorInformation
{
    /// <summary>
    /// ID of the <see href="entity:Vendor">Vendor</see> linked to a default cost of this product.
    /// When the product is added to a purchase order, the default cost is pre-filled.
    /// This field is not validated. Clients should gracefully handle cases where the vendor_id
    /// does not match any existing vendor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor_id")]
    public string? VendorId { get; init; }

    /// <summary>
    /// Unique identifier of this product in the specified vendor's' inventory system.
    /// When the product is added to a purchase order, the vendor code is pre-filled based
    /// on the selected vendor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vendor_code")]
    public string? VendorCode { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit_cost_money")]
    public Money? UnitCostMoney { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
