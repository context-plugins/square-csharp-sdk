using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record OrderUpdatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_updated")]
    public OrderUpdated? OrderUpdated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
