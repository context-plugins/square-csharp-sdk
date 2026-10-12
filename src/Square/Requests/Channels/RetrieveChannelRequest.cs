namespace Square.Requests.Channels;

/// <summary>
/// The inputs of the RetrieveChannel operation.
/// </summary>
public sealed record RetrieveChannelRequest
{
    /// <summary>
    /// A channel id
    /// </summary>
    public required string ChannelId { get; init; }
}
