using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:Loyalty-AdjustLoyaltyPoints">AdjustLoyaltyPoints</see> request.
/// </summary>
public record AdjustLoyaltyPointsResponse
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
