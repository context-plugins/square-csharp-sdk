using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents scheduling information that determines when purchases can qualify to earn points
/// from a <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
/// </summary>
public record LoyaltyPromotionAvailableTimeData
{
    /// <summary>
    /// The date that the promotion starts, in <c>YYYY-MM-DD</c> format. Square populates this field
    /// based on the provided <c>time_periods</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The date that the promotion ends, in <c>YYYY-MM-DD</c> format. Square populates this field
    /// based on the provided <c>time_periods</c>. If an end date is not specified, an <c>ACTIVE</c> promotion
    /// remains available until it is canceled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }

    /// <summary>
    /// A list of <see href="https://tools.ietf.org/html/rfc5545#section-3.6.1">iCalendar (RFC 5545) events</see>
    /// (<c>VEVENT</c>). Each event represents an available time period per day or days of the week.
    /// A day can have a maximum of one available time period.
    /// <para>
    /// Only <c>DTSTART</c>, <c>DURATION</c>, and <c>RRULE</c> are supported. <c>DTSTART</c> and <c>DURATION</c> are required and
    /// timestamps must be in local (unzoned) time format. Include <c>RRULE</c> to specify recurring promotions,
    /// an end date (using the <c>UNTIL</c> keyword), or both. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-promotions#available-time">Available time</see>.
    /// </para>
    /// <para>
    /// Note that <c>BEGIN:VEVENT</c> and <c>END:VEVENT</c> are optional in a <c>CreateLoyaltyPromotion</c> request
    /// but are always included in the response.
    /// </para>
    /// </summary>
    [JsonPropertyName("time_periods")]
    public required IReadOnlyList<string> TimePeriods { get; init; }
}
