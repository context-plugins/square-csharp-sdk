namespace Square.Requests.Catalog;

/// <summary>
/// The inputs of the ListCatalog operation.
/// </summary>
public sealed record ListCatalogRequest
{
    /// <summary>
    /// The pagination cursor returned in the previous response. Leave unset for an initial request.
    /// The page size is currently set to be 100.
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// An optional case-insensitive, comma-separated list of object types to retrieve.
    /// <para>
    /// The valid values are defined in the <see href="entity:CatalogObjectType">CatalogObjectType</see> enum, for example,
    /// <c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>,
    /// <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, <c>IMAGE</c>, etc.
    /// </para>
    /// <para>
    /// If this is unspecified, the operation returns objects of all the top level types at the version
    /// of the Square API used to make the request. Object types that are nested onto other object types
    /// are not included in the defaults.
    /// </para>
    /// <para>
    /// At the current API version the default object types are:
    /// ITEM, CATEGORY, TAX, DISCOUNT, MODIFIER_LIST,
    /// PRICING_RULE, PRODUCT_SET, TIME_PERIOD, MEASUREMENT_UNIT,
    /// SUBSCRIPTION_PLAN, ITEM_OPTION, CUSTOM_ATTRIBUTE_DEFINITION, QUICK_AMOUNT_SETTINGS.
    /// </para>
    /// </summary>
    public string? Types { get; init; }

    /// <summary>
    /// The specific version of the catalog objects to be included in the response.
    /// This allows you to retrieve historical versions of objects. The specified version value is matched against
    /// the <see href="entity:CatalogObject">CatalogObject</see>s' <c>version</c> attribute.  If not included, results will be from the
    /// current version of the catalog.
    /// </summary>
    public long? CatalogVersion { get; init; }
}
