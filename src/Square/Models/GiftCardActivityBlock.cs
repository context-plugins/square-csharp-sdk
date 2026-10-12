using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

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
    public required GiftCardActivityBlockReason Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
