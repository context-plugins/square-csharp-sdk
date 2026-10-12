using Square.Models;

namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the PauseSubscription operation.
/// </summary>
public sealed record PauseSubscriptionOperationRequest
{
    /// <summary>
    /// The ID of the subscription to pause.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required PauseSubscriptionRequest Body { get; init; }
}
