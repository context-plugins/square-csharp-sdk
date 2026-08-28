using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CreateCatalogImageRequest
{
    /// <summary>
    /// A unique string that identifies this CreateCatalogImage request.
    /// Keys can be any valid string but must be unique for every CreateCatalogImage request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Unique ID of the <c>CatalogObject</c> to attach this <c>CatalogImage</c> object to. Leave this
    /// field empty to create unattached images, for example if you are building an integration
    /// where an image can be attached to catalog items at a later time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_id")]
    public string? ObjectId { get; init; }

    /// <summary>
    /// The wrapper object for the catalog entries of a given object type.
    /// <para>
    /// Depending on the <c>type</c> attribute value, a <c>CatalogObject</c> instance assumes a type-specific data to yield the corresponding type of catalog object.
    /// </para>
    /// <para>
    /// For example, if <c>type=ITEM</c>, the <c>CatalogObject</c> instance must have the ITEM-specific data set on the <c>item_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>CatalogItem</c> instance.
    /// </para>
    /// <para>
    /// In general, if <c>type=&lt;OBJECT_TYPE&gt;</c>, the <c>CatalogObject</c> instance must have the <c>&lt;OBJECT_TYPE&gt;</c>-specific data set on the <c>&lt;object_type&gt;_data</c> attribute. The resulting <c>CatalogObject</c> instance is also a <c>Catalog&lt;ObjectType&gt;</c> instance.
    /// </para>
    /// <para>
    /// For a more detailed discussion of the Catalog data model, please see the
    /// <see href="https://developer.squareup.com/docs/catalog-api/design-a-catalog">Design a Catalog</see> guide.
    /// </para>
    /// </summary>
    [JsonPropertyName("image")]
    public required CatalogObject Image { get; init; }

    /// <summary>
    /// If this is set to <c>true</c>, the image created will be the primary, or first image of the object referenced by <c>object_id</c>.
    /// If the <c>CatalogObject</c> already has a primary <c>CatalogImage</c>, setting this field to <c>true</c> will replace the primary image.
    /// If this is set to <c>false</c> and you use the Square API version 2021-12-15 or later, the image id will be appended to the list of <c>image_ids</c> on the object.
    /// <para>
    /// With Square API version 2021-12-15 or later, the default value is <c>false</c>. Otherwise, the effective default value is <c>true</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_primary")]
    public bool? IsPrimary { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
