using Square.Models;

namespace Square.Requests.GiftCardActivities;

/// <summary>
/// The inputs of the CreateGiftCardActivity operation.
/// </summary>
public sealed record CreateGiftCardActivityOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateGiftCardActivityRequest Body { get; init; }
}
