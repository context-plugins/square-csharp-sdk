using Square.Models;

namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the CreateGiftCard operation.
/// </summary>
public sealed record CreateGiftCardOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateGiftCardRequest Body { get; init; }
}
