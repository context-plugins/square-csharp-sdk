using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Filter events by location.
/// </summary>
public record LoyaltyEventLocationFilter
{
    /// <summary>
    /// The <see href="entity:Location">location</see> IDs for loyalty events to query.
    /// If multiple values are specified, the endpoint uses
    /// a logical OR to combine them.
    /// </summary>
    [JsonPropertyName("location_ids")]
    public required IReadOnlyList<string> LocationIds { get; init; }
}
