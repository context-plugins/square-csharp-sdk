using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BatchRetrieveInventoryChangesSortField>))]
public sealed record BatchRetrieveInventoryChangesSortField : OpenStringEnum<BatchRetrieveInventoryChangesSortField>
{
    private BatchRetrieveInventoryChangesSortField(string value) : base(value)
    {
    }

    public static readonly BatchRetrieveInventoryChangesSortField OccurredAt = new("OCCURRED_AT");

    public TResult Match<TResult>(Func<TResult> onOccurredAt, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OccurredAt => onOccurredAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onOccurredAt, Action<string> otherwise)
    {
        if (this == OccurredAt) onOccurredAt();
        else otherwise(Value);
    }
}
