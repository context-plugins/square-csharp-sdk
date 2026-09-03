using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents details about an <c>UNBLOCK</c> <see href="entity:GiftCardActivityType">gift card activity type</see>.
/// </summary>
public record GiftCardActivityUnblock
{
    /// <summary>
    /// Indicates the reason for unblocking a <see href="entity:GiftCard">gift card</see>.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; } = "CHARGEBACK_UNBLOCK";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
