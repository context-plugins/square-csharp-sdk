using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Information about a booking creator.
/// </summary>
public record BookingCreatorDetails
{
    /// <summary>
    /// Supported types of a booking creator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator_type")]
    public BookingCreatorDetailsCreatorType? CreatorType { get; init; }

    /// <summary>
    /// The ID of the team member who created the booking, when the booking creator is of the <c>TEAM_MEMBER</c> type.
    /// Access to this field requires seller-level permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    [MaxLength(32)]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The ID of the customer who created the booking, when the booking creator is of the <c>CUSTOMER</c> type.
    /// Access to this field requires seller-level permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(192)]
    public string? CustomerId { get; init; }
}
