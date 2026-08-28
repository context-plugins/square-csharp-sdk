using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:Loyalty-AccumulateLoyaltyPoints">AccumulateLoyaltyPoints</see> response.
/// </summary>
public record AccumulateLoyaltyPointsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Provides information about a loyalty event.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-events">Search for Balance-Changing Loyalty Events</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public LoyaltyEvent? Event { get; init; }

    /// <summary>
    /// The resulting loyalty events. If the purchase qualifies for points, the <c>ACCUMULATE_POINTS</c> event
    /// is always included. When using the Orders API, the <c>ACCUMULATE_PROMOTION_POINTS</c> event is included
    /// if the purchase also qualifies for a loyalty promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<LoyaltyEvent>? Events { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
