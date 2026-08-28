using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record OrderCreatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_created")]
    public OrderCreated? OrderCreated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
