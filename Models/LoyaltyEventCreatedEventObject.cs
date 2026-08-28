using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record LoyaltyEventCreatedEventObject
{
    /// <summary>
    /// Provides information about a loyalty event.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-events">Search for Balance-Changing Loyalty Events</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_event")]
    public LoyaltyEvent? LoyaltyEvent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
