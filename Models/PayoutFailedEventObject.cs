using System.Text.Json.Serialization;

namespace Square.Models;

public record PayoutFailedEventObject
{
    /// <summary>
    /// An accounting of the amount owed the seller and record of the actual transfer to their
    /// external bank account or to the Square balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payout")]
    public Payout? Payout { get; init; }
}
