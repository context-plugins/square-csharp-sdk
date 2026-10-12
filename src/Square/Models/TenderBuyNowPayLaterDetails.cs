using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>BUY_NOW_PAY_LATER</c>.
/// </summary>
public record TenderBuyNowPayLaterDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_now_pay_later_brand")]
    public TenderBuyNowPayLaterDetailsBrand? BuyNowPayLaterBrand { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TenderBuyNowPayLaterDetailsStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
