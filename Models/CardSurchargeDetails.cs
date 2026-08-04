using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Details related to an attempt to apply a card surcharge to this payment.  When surcharge
/// eligibility is not known in advance, such as when the card type (debit or credit) is required
/// to make the eligibility determination, proposed_card_surcharge_money and
/// proposed_additional_amount_money will match the values in the request, while card_surcharge_money
/// and additional_amount_money are present only when the payment has a surcharge applied.
/// </summary>
public record CardSurchargeDetails
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_surcharge_money")]
    public Money? CardSurchargeMoney { get; init; }
}
