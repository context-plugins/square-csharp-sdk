using System.Text.Json.Serialization;

namespace Square.Models;

public record DisputeEvidenceRemovedEventObject
{
    /// <summary>
    /// Represents a <see href="https://developer.squareup.com/docs/disputes-api/overview">dispute</see> a cardholder initiated with their bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public Dispute? Object { get; init; }
}
