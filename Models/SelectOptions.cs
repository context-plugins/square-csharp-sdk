using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record SelectOptions
{
    /// <summary>
    /// The title text to display in the select flow on the Terminal.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    /// <summary>
    /// The body text to display in the select flow on the Terminal.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(10000, MinimumLength = 1)]
    public required string Body { get; init; }

    /// <summary>
    /// Represents the buttons/options that should be displayed in the select flow on the Terminal.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<SelectOption> Options { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selected_option")]
    public SelectOption? SelectedOption { get; init; }
}
