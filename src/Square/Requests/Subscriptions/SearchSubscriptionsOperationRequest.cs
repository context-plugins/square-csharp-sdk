using Square.Models;

namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the SearchSubscriptions operation.
/// </summary>
public sealed record SearchSubscriptionsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SearchSubscriptionsRequest Body { get; init; }
}
