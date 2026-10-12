using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListPaymentsRequestSortField>))]
public sealed record ListPaymentsRequestSortField : OpenStringEnum<ListPaymentsRequestSortField>
{
    private ListPaymentsRequestSortField(string value) : base(value)
    {
    }

    public static readonly ListPaymentsRequestSortField CreatedAt = new("CREATED_AT");

    public static readonly ListPaymentsRequestSortField OfflineCreatedAt = new("OFFLINE_CREATED_AT");

    public static readonly ListPaymentsRequestSortField UpdatedAt = new("UPDATED_AT");

    public TResult Match<TResult>(Func<TResult> onCreatedAt,
        Func<TResult> onOfflineCreatedAt,
        Func<TResult> onUpdatedAt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CreatedAt => onCreatedAt(),
            _ when this == OfflineCreatedAt => onOfflineCreatedAt(),
            _ when this == UpdatedAt => onUpdatedAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreatedAt, Action onOfflineCreatedAt, Action onUpdatedAt, Action<string> otherwise)
    {
        if (this == CreatedAt) onCreatedAt();
        else if (this == OfflineCreatedAt) onOfflineCreatedAt();
        else if (this == UpdatedAt) onUpdatedAt();
        else otherwise(Value);
    }
}
