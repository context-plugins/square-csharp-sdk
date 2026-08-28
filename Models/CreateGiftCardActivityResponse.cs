using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A response that contains a <c>GiftCardActivity</c> that was created.
/// The response might contain a set of <c>Error</c> objects if the request resulted in errors.
/// </summary>
public record CreateGiftCardActivityResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents an action performed on a <see href="entity:GiftCard">gift card</see> that affects its state or balance.
    /// A gift card activity contains information about a specific activity type. For example, a <c>REDEEM</c> activity
    /// includes a <c>redeem_activity_details</c> field that contains information about the redemption.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_activity")]
    public GiftCardActivity? GiftCardActivity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
