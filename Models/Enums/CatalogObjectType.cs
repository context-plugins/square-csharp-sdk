using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Possible types of CatalogObjects returned from the catalog, each
/// containing type-specific properties in the <c>*_data</c> field corresponding to the specified object type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogObjectType>))]
public sealed record CatalogObjectType : StringEnum<CatalogObjectType>
{
    private CatalogObjectType(string value) : base(value)
    {
    }

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogItem">CatalogItem</see> type and represents an item. The item-specific data
    /// must be set on the <c>item_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Item = new("ITEM");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogImage">CatalogImage</see> type and represents an image. The image-specific data
    /// must be set on the <c>image_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Image = new("IMAGE");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogCategory">CatalogCategory</see> type and represents a category. The category-specific data
    /// must be set on the <c>category_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Category = new("CATEGORY");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the  <see href="entity:CatalogItemVariation">CatalogItemVariation</see> type and represents an item variation, also referred to as variation.
    /// The item variation-specific data must be set on the <c>item_variation_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogTax">CatalogTax</see> type and represents a tax. The tax-specific data
    /// must be set on the <c>tax_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Tax = new("TAX");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogDiscount">CatalogDiscount</see> type and represents a discount. The discount-specific data
    /// must be set on the <c>discount_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Discount = new("DISCOUNT");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogModifierList">CatalogModifierList</see> type and represents a modifier list.
    /// The modifier-list-specific data must be set on the <c>modifier_list_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ModifierList = new("MODIFIER_LIST");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogModifier">CatalogModifier</see> type and represents a modifier. The modifier-specific data
    /// must be set on the <c>modifier_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Modifier = new("MODIFIER");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogPricingRule">CatalogPricingRule</see> type and represents a pricing rule. The pricing-rule-specific data
    /// must be set on the <c>pricing_rule_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType PricingRule = new("PRICING_RULE");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogProductSet">CatalogProductSet</see> type and represents a product set.
    /// The product-set-specific data will be stored in the <c>product_set_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ProductSet = new("PRODUCT_SET");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogTimePeriod">CatalogTimePeriod</see> type and represents a time period.
    /// The time-period-specific data must be set on the <c>time_period_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType TimePeriod = new("TIME_PERIOD");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogMeasurementUnit">CatalogMeasurementUnit</see> type and represents a measurement unit specifying the unit of
    /// measure and precision in which an item variation is sold. The measurement-unit-specific data must set on the <c>measurement_unit_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType MeasurementUnit = new("MEASUREMENT_UNIT");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogSubscriptionPlan">CatalogSubscriptionPlan</see> type and represents a subscription plan.
    /// The subscription-plan-specific data must be stored on the <c>subscription_plan_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType SubscriptionPlanVariation = new("SUBSCRIPTION_PLAN_VARIATION");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogItemOption">CatalogItemOption</see> type and represents a list of options (such as a color or size of a T-shirt)
    /// that can be assigned to item variations. The item-option-specific data must be on the <c>item_option_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ItemOption = new("ITEM_OPTION");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogItemOptionValue">CatalogItemOptionValue</see> type and represents a value associated with one or more item options.
    /// For example, an item option of "Size" may have item option values such as "Small" or "Medium".
    /// The item-option-value-specific data must be on the <c>item_option_value_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ItemOptionVal = new("ITEM_OPTION_VAL");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogCustomAttributeDefinition">CatalogCustomAttributeDefinition</see> type and represents the definition of a custom attribute.
    /// The custom-attribute-definition-specific data must be set on the <c>custom_attribute_definition_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType CustomAttributeDefinition = new("CUSTOM_ATTRIBUTE_DEFINITION");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogQuickAmountsSettings">CatalogQuickAmountsSettings</see> type and represents settings to configure preset charges for quick payments at each location.
    /// For example, a location may have a list of both AUTO and MANUAL quick amounts that are set to DISABLED.
    /// The quick-amounts-settings-specific data must be set on the <c>quick_amounts_settings_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType QuickAmountsSettings = new("QUICK_AMOUNTS_SETTINGS");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogSubscriptionPlan">CatalogSubscriptionPlan</see> type and represents a subscription plan.
    /// The subscription plan specific data must be stored on the <c>subscription_plan_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType SubscriptionPlan = new("SUBSCRIPTION_PLAN");

    /// <summary>
    /// The <c>CatalogObject</c> instance is of the <see href="entity:CatalogAvailabilityPeriod">CatalogAvailabilityPeriod</see> type and represents an availability period.
    /// The availability period specific data must be stored on the <c>availability_period_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType AvailabilityPeriod = new("AVAILABILITY_PERIOD");

    public static CatalogObjectType FromValue(string value) => FromValueCore(value);
}
