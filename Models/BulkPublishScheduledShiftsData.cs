using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents options for an individual publish request in a
/// <see href="api-endpoint:Labor-BulkPublishScheduledShifts">BulkPublishScheduledShifts</see>
/// operation, provided as the value in a key-value pair.
/// </summary>
public record BulkPublishScheduledShiftsData
{
    /// <summary>
    /// The current version of the scheduled shift, used to enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see>
    /// control. If the provided version doesn't match the server version, the request fails.
    /// If omitted, Square executes a blind write, potentially overwriting data from another publish request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
