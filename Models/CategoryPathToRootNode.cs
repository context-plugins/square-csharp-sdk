using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A node in the path from a retrieved category to its root node.
/// </summary>
public record CategoryPathToRootNode
{
    /// <summary>
    /// The category's ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; init; }

    /// <summary>
    /// The category's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_name")]
    public string? CategoryName { get; init; }
}
