using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record OrderFulfillmentUpdatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_fulfillment_updated")]
    public OrderFulfillmentUpdated? OrderFulfillmentUpdated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
