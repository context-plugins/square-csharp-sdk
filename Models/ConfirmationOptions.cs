using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

public record ConfirmationOptions
{
    /// <summary>
    /// The title text to display in the confirmation screen flow on the Terminal.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    /// <summary>
    /// The agreement details to display in the confirmation flow on the Terminal.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(10000, MinimumLength = 1)]
    public required string Body { get; init; }

    /// <summary>
    /// The button text to display indicating the customer agrees to the displayed terms.
    /// </summary>
    [JsonPropertyName("agree_button_text")]
    [StringLength(250, MinimumLength = 1)]
    public required string AgreeButtonText { get; init; }

    /// <summary>
    /// The button text to display indicating the customer does not agree to the displayed terms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disagree_button_text")]
    [StringLength(250, MinimumLength = 1)]
    public string? DisagreeButtonText { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decision")]
    public ConfirmationDecision? Decision { get; init; }
}
