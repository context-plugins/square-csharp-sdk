namespace Square.Requests.Locations;

/// <summary>
/// The inputs of the RetrieveLocation operation.
/// </summary>
public sealed record RetrieveLocationRequest
{
    /// <summary>
    /// The ID of the location to retrieve. Specify the string
    /// "main" to return the main location.
    /// </summary>
    public required string LocationId { get; init; }
}
