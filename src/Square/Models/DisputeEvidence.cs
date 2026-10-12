using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

public record DisputeEvidence
{
    /// <summary>
    /// The Square-generated ID of the evidence.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evidence_id")]
    [StringLength(40, MinimumLength = 1)]
    public string? EvidenceId { get; init; }

    /// <summary>
    /// The Square-generated ID of the evidence.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(40, MinimumLength = 1)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the dispute the evidence is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dispute_id")]
    [StringLength(40, MinimumLength = 1)]
    public string? DisputeId { get; init; }

    /// <summary>
    /// A file to be uploaded as dispute evidence.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evidence_file")]
    public DisputeEvidenceFile? EvidenceFile { get; init; }

    /// <summary>
    /// Raw text
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evidence_text")]
    [StringLength(500, MinimumLength = 1)]
    public string? EvidenceText { get; init; }

    /// <summary>
    /// The time when the evidence was uploaded, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uploaded_at")]
    [StringLength(40, MinimumLength = 1)]
    public string? UploadedAt { get; init; }

    /// <summary>
    /// The type of the dispute evidence.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evidence_type")]
    public DisputeEvidenceType? EvidenceType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
