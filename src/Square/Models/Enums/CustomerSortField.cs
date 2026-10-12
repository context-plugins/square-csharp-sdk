using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Specifies customer attributes as the sort key to customer profiles returned from a search.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CustomerSortField>))]
public sealed record CustomerSortField : OpenStringEnum<CustomerSortField>
{
    private CustomerSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Use the default sort key. By default, customers are sorted
    /// alphanumerically by concatenating their <c>given_name</c> and <c>family_name</c>. If
    /// neither name field is set, string comparison is performed using one of the
    /// remaining fields in the following order: <c>company_name</c>, <c>email</c>,
    /// <c>phone_number</c>.
    /// </summary>
    public static readonly CustomerSortField Default = new("DEFAULT");

    /// <summary>
    /// Use the creation date attribute (<c>created_at</c>) of customer profiles as the sort key.
    /// </summary>
    public static readonly CustomerSortField CreatedAt = new("CREATED_AT");

    public TResult Match<TResult>(Func<TResult> onDefault,
        Func<TResult> onCreatedAt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Default => onDefault(),
            _ when this == CreatedAt => onCreatedAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefault, Action onCreatedAt, Action<string> otherwise)
    {
        if (this == Default) onDefault();
        else if (this == CreatedAt) onCreatedAt();
        else otherwise(Value);
    }
}
