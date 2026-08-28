using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// A response that contains a list of <c>GiftCardActivity</c> objects. If the request resulted in errors,
/// the response contains a set of <c>Error</c> objects.
/// </summary>
public record ListGiftCardActivitiesResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The requested gift card activities or an empty object if none are found.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_activities")]
    public IReadOnlyList<GiftCardActivity>? GiftCardActivities { get; init; }

    /// <summary>
    /// When a response is truncated, it includes a cursor that you can use in a
    /// subsequent request to retrieve the next set of activities. If a cursor is not present, this is
    /// the final response.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
