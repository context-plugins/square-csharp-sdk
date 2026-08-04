using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>CLEAR_BALANCE</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityClearBalance
{
    /// <summary>
    /// Indicates the reason for clearing the balance of a <see href="entity:GiftCard">gift card</see>.
    /// </summary>
    [JsonPropertyName("reason")]
    public required GiftCardActivityClearBalanceReason Reason { get; init; }
}
