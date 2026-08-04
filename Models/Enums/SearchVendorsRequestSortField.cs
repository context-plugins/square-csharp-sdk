using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The field to sort the returned <see href="entity:Vendor">Vendor</see> objects by.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchVendorsRequestSortField>))]
public sealed record SearchVendorsRequestSortField : StringEnum<SearchVendorsRequestSortField>
{
    private SearchVendorsRequestSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// To sort the result by the name of the <see href="entity:Vendor">Vendor</see> objects.
    /// </summary>
    public static readonly SearchVendorsRequestSortField Name = new("NAME");

    /// <summary>
    /// To sort the result by the creation time of the <see href="entity:Vendor">Vendor</see> objects.
    /// </summary>
    public static readonly SearchVendorsRequestSortField CreatedAt = new("CREATED_AT");

    public static SearchVendorsRequestSortField FromValue(string value) => FromValueCore(value);
}
