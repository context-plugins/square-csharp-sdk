namespace Square.Requests.Team;

/// <summary>
/// The inputs of the RetrieveJob operation.
/// </summary>
public sealed record RetrieveJobRequest
{
    /// <summary>
    /// The ID of the job to retrieve.
    /// </summary>
    public required string JobId { get; init; }
}
