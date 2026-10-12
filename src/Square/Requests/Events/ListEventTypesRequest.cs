namespace Square.Requests.Events;

/// <summary>
/// The inputs of the ListEventTypes operation.
/// </summary>
public sealed record ListEventTypesRequest
{
    /// <summary>
    /// The API version for which to list event types. Setting this field overrides the default version used by the application.
    /// </summary>
    public string? ApiVersion { get; init; }
}
