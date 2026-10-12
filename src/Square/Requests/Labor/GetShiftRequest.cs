namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the GetShift operation.
/// </summary>
public sealed record GetShiftRequest
{
    /// <summary>
    /// The UUID for the <c>Shift</c> being retrieved.
    /// </summary>
    public required string Id { get; init; }
}
