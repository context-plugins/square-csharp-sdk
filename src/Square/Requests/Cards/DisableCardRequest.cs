namespace Square.Requests.Cards;

/// <summary>
/// The inputs of the DisableCard operation.
/// </summary>
public sealed record DisableCardRequest
{
    /// <summary>
    /// Unique ID for the desired Card.
    /// </summary>
    public required string CardId { get; init; }
}
