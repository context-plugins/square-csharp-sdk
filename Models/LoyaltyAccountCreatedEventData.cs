using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The data associated with a <c>loyalty.account.created</c> event.
/// </summary>
public record LoyaltyAccountCreatedEventData
{
    /// <summary>
    /// The type of object affected by the event. For this event, the value is <c>loyalty_account</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The ID of the affected loyalty account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public LoyaltyAccountCreatedEventObject? Object { get; init; }
}
