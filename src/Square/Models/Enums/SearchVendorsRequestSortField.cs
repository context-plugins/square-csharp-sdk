using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The field to sort the returned <see href="entity:Vendor">Vendor</see> objects by.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchVendorsRequestSortField>))]
public sealed record SearchVendorsRequestSortField : OpenStringEnum<SearchVendorsRequestSortField>
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

    public TResult Match<TResult>(Func<TResult> onName, Func<TResult> onCreatedAt, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Name => onName(),
            _ when this == CreatedAt => onCreatedAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onName, Action onCreatedAt, Action<string> otherwise)
    {
        if (this == Name) onName();
        else if (this == CreatedAt) onCreatedAt();
        else otherwise(Value);
    }
}
