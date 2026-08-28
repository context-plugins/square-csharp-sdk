using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="api-endpoint:WebhookSubscriptions-ListWebhookEventTypes">ListWebhookEventTypes</see> endpoint.
/// <para>
/// Note: if there are errors processing the request, the event types field will not be
/// present.
/// </para>
/// </summary>
public record ListWebhookEventTypesResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The list of event types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_types")]
    public IReadOnlyList<string>? EventTypes { get; init; }

    /// <summary>
    /// Contains the metadata of a webhook event type. For more information, see <see href="entity:EventTypeMetadata">EventTypeMetadata</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyList<EventTypeMetadata>? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
