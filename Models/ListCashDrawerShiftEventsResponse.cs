using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record ListCashDrawerShiftEventsResponse
{
    /// <summary>
    /// Opaque cursor for fetching the next page. Cursor is not present in
    /// the last page of results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// All of the events (payments, refunds, etc.) for a cash drawer during
    /// the shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_drawer_shift_events")]
    public IReadOnlyList<CashDrawerShiftEvent>? CashDrawerShiftEvents { get; init; }
}
