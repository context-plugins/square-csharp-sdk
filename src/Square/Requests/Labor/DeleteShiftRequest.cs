namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the DeleteShift operation.
/// </summary>
public sealed record DeleteShiftRequest
{
    /// <summary>
    /// The UUID for the <c>Shift</c> being deleted.
    /// </summary>
    public required string Id { get; init; }
}
