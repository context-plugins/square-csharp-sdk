using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Query parameters for searching transfer orders
/// </summary>
public record TransferOrderQuery
{
    /// <summary>
    /// Filter criteria for searching transfer orders
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public TransferOrderFilter? Filter { get; init; }

    /// <summary>
    /// Sort configuration for search results
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public TransferOrderSort? Sort { get; init; }
}
