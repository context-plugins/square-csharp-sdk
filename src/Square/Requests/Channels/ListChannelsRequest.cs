using Square.Models.Enums;

namespace Square.Requests.Channels;

/// <summary>
/// The inputs of the ListChannels operation.
/// </summary>
public sealed record ListChannelsRequest
{
    /// <summary>
    /// Type of reference associated to channel
    /// </summary>
    public ReferenceType? ReferenceType { get; init; }

    /// <summary>
    /// id of reference associated to channel
    /// </summary>
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Status of channel
    /// </summary>
    public ChannelStatus? Status { get; init; }

    /// <summary>
    /// Cursor to fetch the next result
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Maximum number of results to return.
    /// When not provided the returned results will be cap at 100 channels.
    /// </summary>
    public int? Limit { get; init; }
}
