using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Filter by the current order <c>state</c>.
/// </summary>
public record SearchOrdersStateFilter
{
    /// <summary>
    /// States to filter for.
    /// See <see href="#type-orderstate">OrderState</see> for possible values
    /// </summary>
    [JsonPropertyName("states")]
    public required IReadOnlyList<OrderState> States { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
