namespace Square.Requests.WebhookSubscriptions;

/// <summary>
/// The inputs of the ListWebhookEventTypes operation.
/// </summary>
public sealed record ListWebhookEventTypesRequest
{
    /// <summary>
    /// The API version for which to list event types. Setting this field overrides the default version used by the application.
    /// </summary>
    public string? ApiVersion { get; init; }
}
