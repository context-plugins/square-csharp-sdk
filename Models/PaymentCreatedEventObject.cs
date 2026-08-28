using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record PaymentCreatedEventObject
{
    /// <summary>
    /// Represents a payment processed by the Square API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment")]
    public Payment? Payment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
