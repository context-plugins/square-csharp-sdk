using System.Text.Json.Serialization;

namespace Square.Models;

public record OrderUpdatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_updated")]
    public OrderUpdated? OrderUpdated { get; init; }
}
