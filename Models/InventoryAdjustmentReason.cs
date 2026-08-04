using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an inventory adjustment reason.
/// </summary>
public record InventoryAdjustmentReason
{
    /// <summary>
    /// Identifies a standard or custom inventory adjustment reason.
    /// </summary>
    [JsonPropertyName("id")]
    public required InventoryAdjustmentReasonId Id { get; init; }

    /// <summary>
    /// The seller-facing name for a custom inventory adjustment reason. This
    /// field is empty for standard and system-generated adjustment reasons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(50)]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public InventoryAdjustmentReasonDirection? Direction { get; init; }

    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the custom
    /// adjustment reason was created. This field is empty for standard
    /// adjustment reasons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(34)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the custom
    /// adjustment reason was last updated. This field is empty for standard
    /// adjustment reasons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    [MaxLength(34)]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Indicates whether this custom inventory adjustment reason has been
    /// deleted. Deleted custom reasons can still be retrieved by ID, but are
    /// omitted from list responses unless deleted reasons are explicitly included.
    /// To restore a deleted custom reason, call
    /// <see href="api-endpoint:Inventory-RestoreInventoryAdjustmentReason">RestoreInventoryAdjustmentReason</see>.
    /// This field is always <c>false</c> for standard and system-generated adjustment
    /// reasons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; init; }
}
