using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record UpsertCatalogObjectRequest
{
    /// <summary>
    /// A value you specify that uniquely identifies this
    /// request among all your requests. A common way to create
    /// a valid idempotency key is to use a Universally unique
    /// identifier (UUID).
    /// <para>
    /// If you're unsure whether a particular request was successful,
    /// you can reattempt it with the same idempotency key without
    /// worrying about creating duplicate objects.
    /// </para>
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

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
    [JsonPropertyName("object")]
    public required CatalogObject Object { get; init; }
}
