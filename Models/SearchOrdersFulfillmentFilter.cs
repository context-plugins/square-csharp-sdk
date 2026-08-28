using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Filter based on <see href="entity:Fulfillment">order fulfillment</see> information.
/// </summary>
public record SearchOrdersFulfillmentFilter
{
    /// <summary>
    /// A list of <see href="entity:FulfillmentType">fulfillment types</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the fulfillment types
    /// listed in this field.
    /// See <see href="#type-fulfillmenttype">FulfillmentType</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_types")]
    public IReadOnlyList<FulfillmentType?>? FulfillmentTypes { get; init; }

    /// <summary>
    /// A list of <see href="entity:FulfillmentState">fulfillment states</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the
    /// fulfillment states listed in this field.
    /// See <see href="#type-fulfillmentstate">FulfillmentState</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_states")]
    public IReadOnlyList<FulfillmentState?>? FulfillmentStates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
