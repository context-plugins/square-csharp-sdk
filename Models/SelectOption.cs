using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record SelectOption
{
    /// <summary>
    /// The reference id for the option.
    /// </summary>
    [JsonPropertyName("reference_id")]
    [StringLength(40, MinimumLength = 1)]
    public required string ReferenceId { get; init; }

    /// <summary>
    /// The title text that displays in the select option button.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
