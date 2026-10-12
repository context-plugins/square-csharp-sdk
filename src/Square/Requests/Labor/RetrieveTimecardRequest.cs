namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the RetrieveTimecard operation.
/// </summary>
public sealed record RetrieveTimecardRequest
{
    /// <summary>
    /// The UUID for the <c>Timecard</c> being retrieved.
    /// </summary>
    public required string Id { get; init; }
}
