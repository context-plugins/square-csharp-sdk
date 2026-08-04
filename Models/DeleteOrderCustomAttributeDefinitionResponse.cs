using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a response from deleting an order custom attribute definition.
/// </summary>
public record DeleteOrderCustomAttributeDefinitionResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
