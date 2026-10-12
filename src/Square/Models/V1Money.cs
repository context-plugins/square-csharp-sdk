using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record V1Money
{
    /// <summary>
    /// Amount in the lowest denominated value of this Currency. E.g. in USD
    /// these are cents, in JPY they are Yen (which do not have a 'cent' concept).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    /// Indicates the associated currency for an amount of money. Values correspond
    /// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency_code")]
    public Currency? CurrencyCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
