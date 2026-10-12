using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the request body for the
/// <see href="api-endpoint:Channels-BulkRetrieveChannels">BulkRetrieveChannels</see> endpoint.
/// </summary>
public record BulkRetrieveChannelsResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A map of channel IDs to channel responses which tell whether
    /// retrieval for a specific channel is success or not.
    /// Channel response of a success retrieval would contain channel info
    /// whereas channel response of a failed retrieval would have error info.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responses")]
    public IReadOnlyDictionary<string, RetrieveChannelResponse>? Responses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
