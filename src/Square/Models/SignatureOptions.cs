using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record SignatureOptions
{
    /// <summary>
    /// The title text to display in the signature capture flow on the Terminal.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    /// <summary>
    /// The body text to display in the signature capture flow on the Terminal.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(10000, MinimumLength = 1)]
    public required string Body { get; init; }

    /// <summary>
    /// An image representation of the collected signature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public IReadOnlyList<SignatureImage>? Signature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
