namespace Square.Requests.Labor;

/// <summary>
/// The inputs of the DeleteBreakType operation.
/// </summary>
public sealed record DeleteBreakTypeRequest
{
    /// <summary>
    /// The UUID for the <c>BreakType</c> being deleted.
    /// </summary>
    public required string Id { get; init; }
}
