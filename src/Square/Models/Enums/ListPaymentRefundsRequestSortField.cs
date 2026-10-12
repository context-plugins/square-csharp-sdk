using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListPaymentRefundsRequestSortField>))]
public sealed record ListPaymentRefundsRequestSortField : OpenStringEnum<ListPaymentRefundsRequestSortField>
{
    private ListPaymentRefundsRequestSortField(string value) : base(value)
    {
    }

    public static readonly ListPaymentRefundsRequestSortField CreatedAt = new("CREATED_AT");

    public static readonly ListPaymentRefundsRequestSortField UpdatedAt = new("UPDATED_AT");

    public TResult Match<TResult>(Func<TResult> onCreatedAt,
        Func<TResult> onUpdatedAt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreatedAt => onCreatedAt(),
            _ when this == UpdatedAt => onUpdatedAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreatedAt, Action onUpdatedAt, Action<string> otherwise)
    {
        if (this == CreatedAt) onCreatedAt();
        else if (this == UpdatedAt) onUpdatedAt();
        else otherwise(Value);
    }
}
