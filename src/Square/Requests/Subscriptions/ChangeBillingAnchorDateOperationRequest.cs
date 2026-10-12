using Square.Models;

namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the ChangeBillingAnchorDate operation.
/// </summary>
public sealed record ChangeBillingAnchorDateOperationRequest
{
    /// <summary>
    /// The ID of the subscription to update the billing anchor date.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required ChangeBillingAnchorDateRequest Body { get; init; }
}
