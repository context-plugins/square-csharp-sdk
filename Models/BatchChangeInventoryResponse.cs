using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record BatchChangeInventoryResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The current counts for all objects referenced in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counts")]
    public IReadOnlyList<InventoryCount>? Counts { get; init; }

    /// <summary>
    /// Changes created for the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changes")]
    public IReadOnlyList<InventoryChange>? Changes { get; init; }
}
