using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record CustomAttributeEventDataObject
{
    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute")]
    public CustomAttribute? CustomAttribute { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
