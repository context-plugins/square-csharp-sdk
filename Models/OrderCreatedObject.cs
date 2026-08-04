using System.Text.Json.Serialization;

namespace Square.Models;

public record OrderCreatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_created")]
    public OrderCreated? OrderCreated { get; init; }
}
