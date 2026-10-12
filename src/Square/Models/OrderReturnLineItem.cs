using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// The line item being returned in an order.
/// </summary>
public record OrderReturnLineItem
{
    /// <summary>
    /// A unique ID for this return line-item entry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }

    /// <summary>
    /// The <c>uid</c> of the line item in the original sale order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_line_item_uid")]
    [MaxLength(60)]
    public string? SourceLineItemUid { get; init; }

    /// <summary>
    /// The name of the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(512)]
    public string? Name { get; init; }

    /// <summary>
    /// The quantity returned, formatted as a decimal number.
    /// For example, <c>"3"</c>.
    /// <para>
    /// Line items with a <c>quantity_unit</c> can have non-integer quantities.
    /// For example, <c>"1.70000"</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("quantity")]
    [StringLength(12, MinimumLength = 1)]
    public required string Quantity { get; init; }

    /// <summary>
    /// Contains the measurement unit for a quantity and a precision that
    /// specifies the number of digits after the decimal point for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_unit")]
    public OrderQuantityUnit? QuantityUnit { get; init; }

    /// <summary>
    /// The note of the return line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(2000)]
    public string? Note { get; init; }

    /// <summary>
    /// The <see href="entity:CatalogItemVariation">CatalogItemVariation</see> ID applied to this return line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(192)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The version of the catalog object that this line item references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The name of the variation applied to this return line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variation_name")]
    [MaxLength(400)]
    public string? VariationName { get; init; }

    /// <summary>
    /// Represents the line item type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_type")]
    public OrderLineItemItemType? ItemType { get; init; }

    /// <summary>
    /// The <see href="entity:CatalogModifier">CatalogModifier</see>s applied to this line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_modifiers")]
    public IReadOnlyList<OrderReturnLineItemModifier>? ReturnModifiers { get; init; }

    /// <summary>
    /// The list of references to <c>OrderReturnTax</c> entities applied to the return line item. Each
    /// <c>OrderLineItemAppliedTax</c> has a <c>tax_uid</c> that references the <c>uid</c> of a top-level
    /// <c>OrderReturnTax</c> applied to the return line item. On reads, the applied amount
    /// is populated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_taxes")]
    public IReadOnlyList<OrderLineItemAppliedTax>? AppliedTaxes { get; init; }

    /// <summary>
    /// The list of references to <c>OrderReturnDiscount</c> entities applied to the return line item. Each
    /// <c>OrderLineItemAppliedDiscount</c> has a <c>discount_uid</c> that references the <c>uid</c> of a top-level
    /// <c>OrderReturnDiscount</c> applied to the return line item. On reads, the applied amount
    /// is populated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_discounts")]
    public IReadOnlyList<OrderLineItemAppliedDiscount>? AppliedDiscounts { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_price_money")]
    public Money? BasePriceMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variation_total_price_money")]
    public Money? VariationTotalPriceMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_return_money")]
    public Money? GrossReturnMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_tax_money")]
    public Money? TotalTaxMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_discount_money")]
    public Money? TotalDiscountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public Money? TotalMoney { get; init; }

    /// <summary>
    /// The list of references to <c>OrderReturnServiceCharge</c> entities applied to the return
    /// line item. Each <c>OrderLineItemAppliedServiceCharge</c> has a <c>service_charge_uid</c> that
    /// references the <c>uid</c> of a top-level <c>OrderReturnServiceCharge</c> applied to the return line
    /// item. On reads, the applied amount is populated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_service_charges")]
    public IReadOnlyList<OrderLineItemAppliedServiceCharge>? AppliedServiceCharges { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_service_charge_money")]
    public Money? TotalServiceChargeMoney { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
