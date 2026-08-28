using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record SignatureImage
{
    /// <summary>
    /// The mime/type of the image data.
    /// Use <c>image/png;base64</c> for png.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_type")]
    public string? ImageType { get; init; }

    /// <summary>
    /// The base64 representation of the image.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public string? Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
