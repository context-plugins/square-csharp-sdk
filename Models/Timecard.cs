using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A record of the hourly rate, start time, and end time of a single timecard (shift)
/// for a team member. This might include a record of the start and end times of breaks
/// taken during the shift.
/// </summary>
public record Timecard
{
    /// <summary>
    /// <b>Read only</b> The Square-issued UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Location">location</see> for this timecard. The location should be based on
    /// where the team member clocked in.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// <b>Read only</b> The time zone calculated from the location based on the <c>location_id</c>,
    /// provided as a convenience value. Format: the IANA time zone database identifier for the
    /// location time zone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The start time of the timecard, in RFC 3339 format and shifted to the location
    /// timezone + offset. Precision up to the minute is respected; seconds are truncated.
    /// </summary>
    [JsonPropertyName("start_at")]
    [MinLength(1)]
    public required string StartAt { get; init; }

    /// <summary>
    /// The end time of the timecard, in RFC 3339 format and shifted to the location
    /// timezone + offset. Precision up to the minute is respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// The hourly wage rate used to compensate a team member for a <see href="entity:Timecard">timecard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage")]
    public TimecardWage? Wage { get; init; }

    /// <summary>
    /// A list of all the paid or unpaid breaks that were taken during this timecard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("breaks")]
    public IReadOnlyList<Break?>? Breaks { get; init; }

    /// <summary>
    /// <b>Read only</b> Enumerates the possible status of a <see href="entity:Timecard">timecard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TimecardStatus? Status { get; init; }

    /// <summary>
    /// <b>Read only</b> The current version of the timecard, which is incremented with each update.
    /// This field is used for <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control to ensure that requests don't overwrite data from another request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The timestamp of when the timecard was created, in RFC 3339 format presented as UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp of when the timecard was last updated, in RFC 3339 format presented as UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:TeamMember">team member</see> this timecard belongs to.
    /// </summary>
    [JsonPropertyName("team_member_id")]
    [MinLength(1)]
    public required string TeamMemberId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("declared_cash_tip_money")]
    public Money? DeclaredCashTipMoney { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
