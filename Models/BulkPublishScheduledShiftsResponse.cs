using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Labor-BulkPublishScheduledShifts">BulkPublishScheduledShifts</see> response.
/// Either <c>scheduled_shifts</c> or <c>errors</c> is present in the response.
/// </summary>
public record BulkPublishScheduledShiftsResponse
{
    /// <summary>
    /// A map of key-value pairs that represent responses for individual publish requests.
    /// The order of responses might differ from the order in which the requests were provided.
    /// <para>
    /// - Each key is the scheduled shift ID that was specified for a publish request.
    /// - Each value is the corresponding response. If the request succeeds, the value is the
    /// published scheduled shift. If the request fails, the value is an <c>errors</c> array containing
    /// any errors that occurred while processing the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, PublishScheduledShiftResponse>? Responses { get; init; }

    /// <summary>
    /// Any top-level errors that prevented the bulk operation from succeeding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
