using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ListPaymentRefundsRequestSortField>))]
public sealed record ListPaymentRefundsRequestSortField : StringEnum<ListPaymentRefundsRequestSortField>
{
    private ListPaymentRefundsRequestSortField(string value) : base(value)
    {
    }

    public static readonly ListPaymentRefundsRequestSortField CreatedAt = new("CREATED_AT");

    public static readonly ListPaymentRefundsRequestSortField UpdatedAt = new("UPDATED_AT");

    public static ListPaymentRefundsRequestSortField FromValue(string value) => FromValueCore(value);
}
