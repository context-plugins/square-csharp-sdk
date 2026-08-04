using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a file attached to an <see href="entity:Invoice">invoice</see>.
/// </summary>
public record InvoiceAttachment
{
    /// <summary>
    /// The Square-assigned ID of the attachment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The file name of the attachment, which is displayed on the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filename")]
    public string? Filename { get; init; }

    /// <summary>
    /// The description of the attachment, which is displayed on the invoice.
    /// This field maps to the seller-defined <b>Message</b> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The file size of the attachment in bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filesize")]
    public int? Filesize { get; init; }

    /// <summary>
    /// The MD5 hash that was generated from the file contents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hash")]
    public string? Hash { get; init; }

    /// <summary>
    /// The mime type of the attachment.
    /// The following mime types are supported:
    /// image/gif, image/jpeg, image/png, image/tiff, image/bmp, application/pdf.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mime_type")]
    public string? MimeType { get; init; }

    /// <summary>
    /// The timestamp when the attachment was uploaded, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploaded_at")]
    public string? UploadedAt { get; init; }
}
