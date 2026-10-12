using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record DataCollectionOptions
{
    /// <summary>
    /// The title text to display in the data collection flow on the Terminal.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    /// <summary>
    /// The body text to display under the title in the data collection screen flow on the
    /// Terminal.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(10000, MinimumLength = 1)]
    public required string Body { get; init; }

    /// <summary>
    /// Describes the input type of the data.
    /// </summary>
    [JsonPropertyName("input_type")]
    public required DataCollectionOptionsInputType InputType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collected_data")]
    public CollectedData? CollectedData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
