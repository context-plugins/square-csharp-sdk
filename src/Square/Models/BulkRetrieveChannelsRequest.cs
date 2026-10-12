using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the request body for the
/// <see href="api-endpoint:Channels-BulkRetrieveChannels">BulkRetrieveChannels</see> endpoint.
/// </summary>
public record BulkRetrieveChannelsRequest
{
    [JsonPropertyName("channel_ids")]
    public required IReadOnlyList<string> ChannelIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
