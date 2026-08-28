using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Filter events by event type.
/// </summary>
public record LoyaltyEventTypeFilter
{
    /// <summary>
    /// The loyalty event types used to filter the result.
    /// If multiple values are specified, the endpoint uses a
    /// logical OR to combine them.
    /// See <see href="#type-loyaltyeventtype">LoyaltyEventType</see> for possible values
    /// </summary>
    [JsonPropertyName("types")]
    public required IReadOnlyList<LoyaltyEventType> Types { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
