using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The data associated with a <c>loyalty.program.updated</c> event.
/// </summary>
public record LoyaltyProgramUpdatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>loyalty_program</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the affected loyalty program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// An object that contains the loyalty program associated with a <c>loyalty.program.updated</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public LoyaltyProgramUpdatedEventObject? Object { get; init; }
}
