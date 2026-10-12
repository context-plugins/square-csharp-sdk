using Square.Models;

namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the RetrieveGiftCardFromNonce operation.
/// </summary>
public sealed record RetrieveGiftCardFromNonceOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RetrieveGiftCardFromNonceRequest Body { get; init; }
}
