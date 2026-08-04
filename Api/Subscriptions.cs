using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Square.Core;
using Square.Core.ErrorResponse;
using Square.Core.Exceptions;
using Square.Core.Models;
using Square.Core.Request;
using Square.Core.Response;
using Square.Models;

namespace Square.Api;

public sealed class Subscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Subscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkSwapPlan
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkSwapPlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a plan variation change for all active subscriptions under a given plan
    /// variation. For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/swap-plan-variations">Swap Subscription Plan Variations</see>.
    /// </remarks>
    public Task<BulkSwapPlanResponse> BulkSwapPlan(BulkSwapPlanRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/bulk-swap-plan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkSwapPlanResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CancelSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to cancel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a <c>CANCEL</c> action to cancel an active subscription. This
    /// sets the <c>canceled_date</c> field to the end of the active billing period. After this date,
    /// the subscription status changes from ACTIVE to CANCELED.
    /// </remarks>
    public Task<CancelSubscriptionResponse> CancelSubscription(string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/cancel"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ChangeBillingAnchorDate
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to update the billing anchor date.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChangeBillingAnchorDateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://developer.squareup.com/docs/subscriptions-api/subscription-billing#billing-dates">billing anchor date</see>
    /// for a subscription.
    /// </remarks>
    public Task<ChangeBillingAnchorDateResponse> ChangeBillingAnchorDate(string subscriptionId,
        ChangeBillingAnchorDateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/billing-anchor"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ChangeBillingAnchorDateResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateSubscription
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enrolls a customer in a subscription.
    /// <para>
    /// If you provide a card on file in the request, Square charges the card for
    /// the subscription. Otherwise, Square sends an invoice to the customer's email
    /// address. The subscription starts immediately, unless the request includes
    /// the optional <c>start_date</c>. Each individual subscription is associated with a particular location.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/manage-subscriptions#create-a-subscription">Create a subscription</see>.
    /// </para>
    /// </remarks>
    public Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteSubscriptionAction
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription the targeted action is to act upon.</param>
    /// <param name="actionId">The ID of the targeted action to be deleted.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteSubscriptionActionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a scheduled action for a subscription.
    /// </remarks>
    public Task<DeleteSubscriptionActionResponse> DeleteSubscriptionAction(string subscriptionId,
        string actionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/actions/{action_id}"),
            [new TemplateParam("subscription_id", subscriptionId), new TemplateParam("action_id", actionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteSubscriptionActionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListSubscriptionEvents
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to retrieve the events for.</param>
    /// <param name="cursor">When the total number of resulting subscription events exceeds the limit of a paged response,  specify the cursor returned from a preceding response here to fetch the next set of results. If the cursor is unset, the response contains the last page of the results.  For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="limit">The upper limit on the number of subscription events to return in a paged response.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListSubscriptionEventsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all <see href="https://developer.squareup.com/docs/subscriptions-api/actions-events">events</see> for a specific subscription.
    /// </remarks>
    public Task<ListSubscriptionEventsResponse> ListSubscriptionEvents(string subscriptionId,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/events"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListSubscriptionEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// PauseSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to pause.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PauseSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a <c>PAUSE</c> action to pause an active subscription.
    /// </remarks>
    public Task<PauseSubscriptionResponse> PauseSubscription(string subscriptionId,
        PauseSubscriptionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/pause"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PauseSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ResumeSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to resume.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ResumeSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a <c>RESUME</c> action to resume a paused or a deactivated subscription.
    /// </remarks>
    public Task<ResumeSubscriptionResponse> ResumeSubscription(string subscriptionId,
        ResumeSubscriptionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/resume"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ResumeSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to retrieve.</param>
    /// <param name="include">A query parameter to specify related information to be included in the response.   The supported query parameter values are:   - <c>actions</c>: to include scheduled actions on the targeted subscription.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific subscription.
    /// </remarks>
    public Task<RetrieveSubscriptionResponse> RetrieveSubscription(string subscriptionId,
        string? include,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [new Param("include", include)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchSubscriptions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchSubscriptionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for subscriptions.
    /// <para>
    /// Results are ordered chronologically by subscription creation date. If
    /// the request specifies more than one location ID,
    /// the endpoint orders the result
    /// by location ID, and then by creation date within each location. If no locations are given
    /// in the query, all locations are searched.
    /// </para>
    /// <para>
    /// You can also optionally specify <c>customer_ids</c> to search by customer.
    /// If left unset, all customers
    /// associated with the specified locations are returned.
    /// If the request specifies customer IDs, the endpoint orders results
    /// first by location, within location by customer ID, and within
    /// customer by subscription creation date.
    /// </para>
    /// </remarks>
    public Task<SearchSubscriptionsResponse> SearchSubscriptions(SearchSubscriptionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchSubscriptionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SwapPlan
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to swap the subscription plan for.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SwapPlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a <c>SWAP_PLAN</c> action to swap a subscription plan variation in an existing subscription.
    /// For more information, see <see href="https://developer.squareup.com/docs/subscriptions-api/swap-plan-variations">Swap Subscription Plan Variations</see>.
    /// </remarks>
    public Task<SwapPlanResponse> SwapPlan(string subscriptionId,
        SwapPlanRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/swap-plan"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SwapPlanResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// UpdateSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a subscription by modifying or clearing <c>subscription</c> field values.
    /// To clear a field, set its value to <c>null</c>.
    /// </remarks>
    public Task<UpdateSubscriptionResponse> UpdateSubscription(string subscriptionId,
        UpdateSubscriptionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}
