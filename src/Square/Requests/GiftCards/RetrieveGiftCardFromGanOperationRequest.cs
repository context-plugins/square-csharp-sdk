using Square.Models;

namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the RetrieveGiftCardFromGan operation.
/// </summary>
public sealed record RetrieveGiftCardFromGanOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RetrieveGiftCardFromGanRequest Body { get; init; }
}
