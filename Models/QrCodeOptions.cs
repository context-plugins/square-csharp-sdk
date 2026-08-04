using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Fields to describe the action that displays QR-Codes.
/// </summary>
public record QrCodeOptions
{
    /// <summary>
    /// The title text to display in the QR code flow on the Terminal.
    /// </summary>
    [JsonPropertyName("title")]
    [StringLength(250, MinimumLength = 1)]
    public required string Title { get; init; }

    /// <summary>
    /// The body text to display in the QR code flow on the Terminal.
    /// </summary>
    [JsonPropertyName("body")]
    [StringLength(10000, MinimumLength = 1)]
    public required string Body { get; init; }

    /// <summary>
    /// The text representation of the data to show in the QR code
    /// as UTF8-encoded data.
    /// </summary>
    [JsonPropertyName("barcode_contents")]
    [StringLength(1024, MinimumLength = 1)]
    public required string BarcodeContents { get; init; }
}
