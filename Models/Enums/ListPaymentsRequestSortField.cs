using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListPaymentsRequestSortField>))]
public sealed record ListPaymentsRequestSortField : StringEnum<ListPaymentsRequestSortField>
{
    private ListPaymentsRequestSortField(string value) : base(value)
    {
    }

    public static readonly ListPaymentsRequestSortField CreatedAt = new("CREATED_AT");

    public static readonly ListPaymentsRequestSortField OfflineCreatedAt = new("OFFLINE_CREATED_AT");

    public static readonly ListPaymentsRequestSortField UpdatedAt = new("UPDATED_AT");

    public static ListPaymentsRequestSortField FromValue(string value) => FromValueCore(value);
}
