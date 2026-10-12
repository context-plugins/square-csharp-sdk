using Square.Models;

namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the SwapPlan operation.
/// </summary>
public sealed record SwapPlanOperationRequest
{
    /// <summary>
    /// The ID of the subscription to swap the subscription plan for.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required SwapPlanRequest Body { get; init; }
}
