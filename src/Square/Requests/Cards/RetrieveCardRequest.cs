namespace Square.Requests.Cards;

/// <summary>
/// The inputs of the RetrieveCard operation.
/// </summary>
public sealed record RetrieveCardRequest
{
    /// <summary>
    /// Unique ID for the desired Card.
    /// </summary>
    public required string CardId { get; init; }
}
