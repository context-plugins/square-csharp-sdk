namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the RetrieveScheduledShift operation.
/// </summary>
public sealed record RetrieveScheduledShiftRequest
{
    /// <summary>
    /// The ID of the scheduled shift to retrieve.
    /// </summary>
    public required string Id { get; init; }
}
