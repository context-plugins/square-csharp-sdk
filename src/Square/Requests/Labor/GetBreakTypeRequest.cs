namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the GetBreakType operation.
/// </summary>
public sealed record GetBreakTypeRequest
{
    /// <summary>
    /// The UUID for the <c>BreakType</c> being retrieved.
    /// </summary>
    public required string Id { get; init; }
}
