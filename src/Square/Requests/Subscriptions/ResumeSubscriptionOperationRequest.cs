using Square.Models;

namespace Square.Requests.Subscriptions;

/// <summary>
/// The inputs of the ResumeSubscription operation.
/// </summary>
public sealed record ResumeSubscriptionOperationRequest
{
    /// <summary>
    /// The ID of the subscription to resume.
    /// </summary>
    public required string SubscriptionId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required ResumeSubscriptionRequest Body { get; init; }
}
