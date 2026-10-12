namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the RetrieveLocationSettings operation.
/// </summary>
public sealed record RetrieveLocationSettingsRequest
{
    /// <summary>
    /// The ID of the location for which to retrieve settings.
    /// </summary>
    public required string LocationId { get; init; }
}
