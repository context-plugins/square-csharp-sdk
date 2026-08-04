using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents details about a <c>BLOCK</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityBlock
{
    /// <summary>
    /// Indicates the reason for blocking a <see href="entity:GiftCard">gift card</see>.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; } = "CHARGEBACK_BLOCK";
}
