using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A <see href="entity:CatalogObject">CatalogObject</see> instance of the <c>ITEM</c> type, also referred to as an item, in the catalog.
/// </summary>
public record CatalogItem
{
    /// <summary>
    /// The item's name. This is a searchable attribute for use in applicable query filters, its value must not be empty, and the length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(512)]
    public string? Name { get; init; }

    /// <summary>
    /// The item's description. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// <para>
    /// Deprecated at 2022-07-20, this field is planned to retire in 6 months. You should migrate to use <c>description_html</c> to set the description
    /// of the <see href="entity:CatalogItem">CatalogItem</see> instance.  The <c>description</c> and <c>description_html</c> field values are kept in sync. If you try to
    /// set the both fields, the <c>description_html</c> text value overwrites the <c>description</c> value. Updates in one field are also reflected in the other,
    /// except for when you use an early version before Square API 2022-07-20 and <c>description_html</c> is set to blank, setting the <c>description</c> value to null
    /// does not nullify <c>description_html</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(4096)]
    public string? Description { get; init; }

    /// <summary>
    /// The text of the item's display label in the Square Point of Sale app. Only up to the first five characters of the string are used.
    /// This attribute is searchable, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abbreviation")]
    [MaxLength(24)]
    public string? Abbreviation { get; init; }

    /// <summary>
    /// The color of the item's display label in the Square Point of Sale app. This must be a valid hex color code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label_color")]
    public string? LabelColor { get; init; }

    /// <summary>
    /// Indicates whether the item is taxable (<c>true</c>) or non-taxable (<c>false</c>). Default is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_taxable")]
    public bool? IsTaxable { get; init; }

    /// <summary>
    /// The ID of the item's category, if any. Deprecated since 2023-12-13. Use <c>CatalogItem.categories</c>, instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; init; }

    /// <summary>
    /// The override to a product name to display to users
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_facing_name")]
    [MaxLength(512)]
    public string? BuyerFacingName { get; init; }

    /// <summary>
    /// A set of IDs indicating the taxes enabled for
    /// this item. When updating an item, any taxes listed here will be added to the item.
    /// Taxes may also be added to or deleted from an item using <c>UpdateItemTaxes</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public IReadOnlyList<string?>? TaxIds { get; init; }

    /// <summary>
    /// A set of <c>CatalogItemModifierListInfo</c> objects
    /// representing the modifier lists that apply to this item, along with the overrides and min
    /// and max limits that are specific to this item. Modifier lists
    /// may also be added to or deleted from an item using <c>UpdateItemModifierLists</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_list_info")]
    public IReadOnlyList<CatalogItemModifierListInfo?>? ModifierListInfo { get; init; }

    /// <summary>
    /// A list of <see href="entity:CatalogItemVariation">CatalogItemVariation</see> objects for this item. An item must have
    /// at least one variation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variations")]
    public IReadOnlyList<CatalogObject?>? Variations { get; init; }

    /// <summary>
    /// The type of a CatalogItem. Connect V2 only allows the creation of <c>REGULAR</c> or <c>APPOINTMENTS_SERVICE</c> items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_type")]
    public CatalogItemProductType? ProductType { get; init; }

    /// <summary>
    /// If <c>false</c>, the Square Point of Sale app will present the <c>CatalogItem</c>'s
    /// details screen immediately, allowing the merchant to choose <c>CatalogModifier</c>s
    /// before adding the item to the cart.  This is the default behavior.
    /// <para>
    /// If <c>true</c>, the Square Point of Sale app will immediately add the item to the cart with the pre-selected
    /// modifiers, and merchants can edit modifiers by drilling down onto the item's details.
    /// </para>
    /// <para>
    /// Third-party clients are encouraged to implement similar behaviors.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_modifier_screen")]
    public bool? SkipModifierScreen { get; init; }

    /// <summary>
    /// List of item options IDs for this item. Used to manage and group item
    /// variations in a specified order.
    /// <para>
    /// Maximum: 6 item options.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_options")]
    public IReadOnlyList<CatalogItemOptionForItem?>? ItemOptions { get; init; }

    /// <summary>
    /// Deprecated. A URI pointing to a published e-commerce product page for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecom_uri")]
    public string? EcomUri { get; init; }

    /// <summary>
    /// Deprecated. A comma-separated list of encoded URIs pointing to a set of published e-commerce images for the Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecom_image_uris")]
    public IReadOnlyList<string?>? EcomImageUris { get; init; }

    /// <summary>
    /// The IDs of images associated with this <c>CatalogItem</c> instance.
    /// These images will be shown to customers in Square Online Store.
    /// The first image will show up as the icon for this item in POS.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_ids")]
    public IReadOnlyList<string?>? ImageIds { get; init; }

    /// <summary>
    /// A name to sort the item by. If this name is unspecified, namely, the <c>sort_name</c> field is absent, the regular <c>name</c> field is used for sorting.
    /// Its value must not be empty.
    /// <para>
    /// It is currently supported for sellers of the Japanese locale only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_name")]
    public string? SortName { get; init; }

    /// <summary>
    /// The list of categories to which this item belongs. Each entry includes the category ID and an ordinal
    /// value that determines the item's relative position within that category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categories")]
    public IReadOnlyList<CatalogObjectCategory?>? Categories { get; init; }

    /// <summary>
    /// The item's description as expressed in valid HTML elements. The length of this field value, including those of HTML tags,
    /// is of Unicode points. With application query filters, the text values of the HTML elements and attributes are searchable. Invalid or
    /// unsupported HTML elements or attributes are ignored.
    /// <para>
    /// Supported HTML elements include:
    /// - <c>a</c>: Link. Supports linking to website URLs, email address, and telephone numbers.
    /// - <c>b</c>, <c>strong</c>:  Bold text
    /// - <c>br</c>: Line break
    /// - <c>code</c>: Computer code
    /// - <c>div</c>: Section
    /// - <c>h1-h6</c>: Headings
    /// - <c>i</c>, <c>em</c>: Italics
    /// - <c>li</c>: List element
    /// - <c>ol</c>: Numbered list
    /// - <c>p</c>: Paragraph
    /// - <c>ul</c>: Bullet list
    /// - <c>u</c>: Underline
    /// </para>
    /// <para>
    ///
    /// Supported HTML attributes include:
    /// - <c>align</c>: Alignment of the text content
    /// - <c>href</c>: Link destination
    /// - <c>rel</c>: Relationship between link's target and source
    /// - <c>target</c>: Place to open the linked document
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_html")]
    [MaxLength(65535)]
    public string? DescriptionHtml { get; init; }

    /// <summary>
    /// A server-generated plaintext version of the <c>description_html</c> field, without formatting tags.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_plaintext")]
    [MaxLength(65535)]
    public string? DescriptionPlaintext { get; init; }

    /// <summary>
    /// (Optional) Name that the restaurant wants to display to their kitchen workers
    /// instead of the customer-facing name.
    /// e.g., customer name might be "Big John's Mega Burger" and the
    /// kitchen name is "12oz beef burger"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kitchen_name")]
    public string? KitchenName { get; init; }

    /// <summary>
    /// A list of IDs representing channels, such as a Square Online site, where the item can be made visible or available.
    /// This field is read only and cannot be edited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channels")]
    public IReadOnlyList<string?>? Channels { get; init; }

    /// <summary>
    /// Indicates whether this item is archived (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_archived")]
    public bool? IsArchived { get; init; }

    /// <summary>
    /// SEO data for for a seller's Square Online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecom_seo_data")]
    public CatalogEcomSeoData? EcomSeoData { get; init; }

    /// <summary>
    /// The food and beverage-specific details of a <c>FOOD_AND_BEV</c> item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("food_and_beverage_details")]
    public CatalogItemFoodAndBeverageDetails? FoodAndBeverageDetails { get; init; }

    /// <summary>
    /// A category that can be assigned to an item or a parent category that can be assigned
    /// to another category. For example, a clothing category can be assigned to a t-shirt item or
    /// be made as the parent category to the pants category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reporting_category")]
    public CatalogObjectCategory? ReportingCategory { get; init; }

    /// <summary>
    /// Indicates whether this item is alcoholic (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_alcoholic")]
    public bool? IsAlcoholic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
