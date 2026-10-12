using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Filter criteria for searching transfer orders
/// </summary>
public record TransferOrderFilter
{
    /// <summary>
    /// Filter by source location IDs
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_location_ids")]
    public IReadOnlyList<string>? SourceLocationIds { get; init; }

    /// <summary>
    /// Filter by destination location IDs
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination_location_ids")]
    public IReadOnlyList<string>? DestinationLocationIds { get; init; }

    /// <summary>
    /// Filter by order statuses
    /// See <see href="#type-transferorderstatus">TransferOrderStatus</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statuses")]
    public IReadOnlyList<TransferOrderStatus>? Statuses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
