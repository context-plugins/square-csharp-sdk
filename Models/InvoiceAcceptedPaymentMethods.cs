using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The payment methods that customers can use to pay an <see href="entity:Invoice">invoice</see> on the Square-hosted invoice payment page.
/// </summary>
public record InvoiceAcceptedPaymentMethods
{
    /// <summary>
    /// Indicates whether credit card or debit card payments are accepted. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public bool? Card { get; init; }

    /// <summary>
    /// Indicates whether Square gift card payments are accepted. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_gift_card")]
    public bool? SquareGiftCard { get; init; }

    /// <summary>
    /// Indicates whether ACH bank transfer payments are accepted. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public bool? BankAccount { get; init; }

    /// <summary>
    /// Indicates whether Afterpay (also known as Clearpay) payments are accepted. The default value is <c>false</c>.
    /// <para>
    /// This option is allowed only for invoices that have a single payment request of the <c>BALANCE</c> type. This payment method is
    /// supported if the seller account accepts Afterpay payments and the seller location is in a country where Afterpay
    /// invoice payments are supported. As a best practice, consider enabling an additional payment method when allowing
    /// <c>buy_now_pay_later</c> payments. For more information, including detailed requirements and processing limits, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#buy-now-pay-later">Buy Now Pay Later payments with Afterpay</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_now_pay_later")]
    public bool? BuyNowPayLater { get; init; }

    /// <summary>
    /// Indicates whether Cash App payments are accepted. The default value is <c>false</c>.
    /// <para>
    /// This payment method is supported only for seller <see href="entity:Location">locations</see> in the United States.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_app_pay")]
    public bool? CashAppPay { get; init; }
}
