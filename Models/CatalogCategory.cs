using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A category to which a <c>CatalogItem</c> instance belongs.
/// </summary>
public record CatalogCategory
{
    /// <summary>
    /// The category name. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The IDs of images associated with this <c>CatalogCategory</c> instance.
    /// Currently these images are not displayed by Square, but are free to be displayed in 3rd party applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_ids")]
    public IReadOnlyList<string?>? ImageIds { get; init; }

    /// <summary>
    /// Indicates the type of a category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_type")]
    public CatalogCategoryType? CategoryType { get; init; }

    /// <summary>
    /// A category that can be assigned to an item or a parent category that can be assigned
    /// to another category. For example, a clothing category can be assigned to a t-shirt item or
    /// be made as the parent category to the pants category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_category")]
    public CatalogObjectCategory? ParentCategory { get; init; }

    /// <summary>
    /// Indicates whether a category is a top level category, which does not have any parent_category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_top_level")]
    public bool? IsTopLevel { get; init; }

    /// <summary>
    /// A list of IDs representing channels, such as a Square Online site, where the category can be made visible.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channels")]
    public IReadOnlyList<string?>? Channels { get; init; }

    /// <summary>
    /// The IDs of the <c>CatalogAvailabilityPeriod</c> objects associated with the category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availability_period_ids")]
    public IReadOnlyList<string?>? AvailabilityPeriodIds { get; init; }

    /// <summary>
    /// Indicates whether the category is visible (<c>true</c>) or hidden (<c>false</c>) on all of the seller's Square Online sites.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("online_visibility")]
    public bool? OnlineVisibility { get; init; }

    /// <summary>
    /// The top-level category in a category hierarchy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("root_category")]
    public string? RootCategory { get; init; }

    /// <summary>
    /// SEO data for for a seller's Square Online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ecom_seo_data")]
    public CatalogEcomSeoData? EcomSeoData { get; init; }

    /// <summary>
    /// The path from the category to its root category. The first node of the path is the parent of the category
    /// and the last is the root category. The path is empty if the category is a root category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("path_to_root")]
    public IReadOnlyList<CategoryPathToRootNode?>? PathToRoot { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
