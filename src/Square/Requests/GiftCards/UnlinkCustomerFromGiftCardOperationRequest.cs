using Square.Models;

namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the UnlinkCustomerFromGiftCard operation.
/// </summary>
public sealed record UnlinkCustomerFromGiftCardOperationRequest
{
    /// <summary>
    /// The ID of the gift card to be unlinked.
    /// </summary>
    public required string GiftCardId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UnlinkCustomerFromGiftCardRequest Body { get; init; }
}
