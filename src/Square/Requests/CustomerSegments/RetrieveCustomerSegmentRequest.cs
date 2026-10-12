namespace Square.Requests.CustomerSegments;

/// <summary>
/// The inputs of the RetrieveCustomerSegment operation.
/// </summary>
public sealed record RetrieveCustomerSegmentRequest
{
    /// <summary>
    /// The Square-issued ID of the customer segment.
    /// </summary>
    public required string SegmentId { get; init; }
}
