using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record PayoutSentEventObject
{
    /// <summary>
    /// An accounting of the amount owed the seller and record of the actual transfer to their
    /// external bank account or to the Square balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payout")]
    public Payout? Payout { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
