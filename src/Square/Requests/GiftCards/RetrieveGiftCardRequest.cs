namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the RetrieveGiftCard operation.
/// </summary>
public sealed record RetrieveGiftCardRequest
{
    /// <summary>
    /// The ID of the gift card to retrieve.
    /// </summary>
    public required string Id { get; init; }
}
