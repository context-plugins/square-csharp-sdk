using Square.Models;

namespace Square.Requests.Channels;

/// <summary>
/// The inputs of the BulkRetrieveChannels operation.
/// </summary>
public sealed record BulkRetrieveChannelsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required BulkRetrieveChannelsRequest Body { get; init; }
}
