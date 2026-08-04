using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Loyalty-CalculateLoyaltyPoints">CalculateLoyaltyPoints</see> request.
/// </summary>
public record CalculateLoyaltyPointsRequest
{
    /// <summary>
    /// The <see href="entity:Order">order</see> ID for which to calculate the points.
    /// Specify this field if your application uses the Orders API to process orders.
    /// Otherwise, specify the <c>transaction_amount_money</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_amount_money")]
    public Money? TransactionAmountMoney { get; init; }

    /// <summary>
    /// The ID of the target <see href="entity:LoyaltyAccount">loyalty account</see>. Optionally specify this field
    /// if your application uses the Orders API to process orders.
    /// <para>
    /// If specified, the <c>promotion_points</c> field in the response shows the number of points the buyer would
    /// earn from the purchase. In this case, Square uses the account ID to determine whether the promotion's
    /// <c>trigger_limit</c> (the maximum number of times that a buyer can trigger the promotion) has been reached.
    /// If not specified, the <c>promotion_points</c> field shows the number of points the purchase qualifies
    /// for regardless of the trigger limit.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_account_id")]
    [StringLength(36, MinimumLength = 1)]
    public string? LoyaltyAccountId { get; init; }
}
