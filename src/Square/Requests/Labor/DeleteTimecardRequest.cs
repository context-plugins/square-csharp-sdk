namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the DeleteTimecard operation.
/// </summary>
public sealed record DeleteTimecardRequest
{
    /// <summary>
    /// The UUID for the <c>Timecard</c> being deleted.
    /// </summary>
    public required string Id { get; init; }
}
