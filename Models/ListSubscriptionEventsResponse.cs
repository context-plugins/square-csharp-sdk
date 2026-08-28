using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines output parameters in a response from the
/// <see href="api-endpoint:Subscriptions-ListSubscriptionEvents">ListSubscriptionEvents</see>.
/// </summary>
public record ListSubscriptionEventsResponse
{
    /// <summary>
    /// Errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The retrieved subscription events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_events")]
    public IReadOnlyList<SubscriptionEvent>? SubscriptionEvents { get; init; }

    /// <summary>
    /// When the total number of resulting subscription events exceeds the limit of a paged response,
    /// the response includes a cursor for you to use in a subsequent request to fetch the next set of events.
    /// If the cursor is unset, the response contains the last page of the results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
