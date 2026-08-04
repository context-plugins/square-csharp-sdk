using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BatchRetrieveInventoryChangesSortField>))]
public sealed record BatchRetrieveInventoryChangesSortField : StringEnum<BatchRetrieveInventoryChangesSortField>
{
    private BatchRetrieveInventoryChangesSortField(string value) : base(value)
    {
    }

    public static readonly BatchRetrieveInventoryChangesSortField OccurredAt = new("OCCURRED_AT");

    public static BatchRetrieveInventoryChangesSortField FromValue(string value) => FromValueCore(value);
}
