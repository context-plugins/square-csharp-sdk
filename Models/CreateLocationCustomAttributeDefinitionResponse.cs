using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:LocationCustomAttributes-CreateLocationCustomAttributeDefinition">CreateLocationCustomAttributeDefinition</see> response.
/// Either <c>custom_attribute_definition</c> or <c>errors</c> is present in the response.
/// </summary>
public record CreateLocationCustomAttributeDefinitionResponse
{
    /// <summary>
    /// Represents a definition for custom attribute values. A custom attribute definition
    /// specifies the key, visibility, schema, and other properties for a custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition")]
    public CustomAttributeDefinition? CustomAttributeDefinition { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
