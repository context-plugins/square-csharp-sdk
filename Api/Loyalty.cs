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
using Square.Models.Enums;

namespace Square.Api;

public sealed class Loyalty
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Loyalty(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AccumulateLoyaltyPoints
    /// </summary>
    /// <param name="accountId">The ID of the target <see href="entity:LoyaltyAccount">loyalty account</see>.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccumulateLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds points earned from a purchase to a <see href="entity:LoyaltyAccount">loyalty account</see>.
    /// <para>
    /// - If you are using the Orders API to manage orders, provide the <c>order_id</c>. Square reads the order
    /// to compute the points earned from both the base loyalty program and an associated
    /// <see href="entity:LoyaltyPromotion">loyalty promotion</see>. For purchases that qualify for multiple accrual
    /// rules, Square computes points based on the accrual rule that grants the most points.
    /// For purchases that qualify for multiple promotions, Square computes points based on the most
    /// recently created promotion. A purchase must first qualify for program points to be eligible for promotion points.
    /// </para>
    /// <para>
    /// - If you are not using the Orders API to manage orders, provide <c>points</c> with the number of points to add.
    /// You must first perform a client-side computation of the points earned from the loyalty program and
    /// loyalty promotion. For spend-based and visit-based programs, you can call <see href="api-endpoint:Loyalty-CalculateLoyaltyPoints">CalculateLoyaltyPoints</see>
    /// to compute the points earned from the base loyalty program. For information about computing points earned from a loyalty promotion, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-promotions#calculate-promotion-points">Calculating promotion points</see>.
    /// </para>
    /// </remarks>
    public Task<AccumulateLoyaltyPointsResponse> AccumulateLoyaltyPoints(string accountId,
        AccumulateLoyaltyPointsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}/accumulate"),
            [new TemplateParam("account_id", accountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccumulateLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// AdjustLoyaltyPoints
    /// </summary>
    /// <param name="accountId">The ID of the target <see href="entity:LoyaltyAccount">loyalty account</see>.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdjustLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds points to or subtracts points from a buyer's account.
    /// <para>
    /// Use this endpoint only when you need to manually adjust points. Otherwise, in your application flow, you call
    /// <see href="api-endpoint:Loyalty-AccumulateLoyaltyPoints">AccumulateLoyaltyPoints</see>
    /// to add points when a buyer pays for the purchase.
    /// </para>
    /// </remarks>
    public Task<AdjustLoyaltyPointsResponse> AdjustLoyaltyPoints(string accountId,
        AdjustLoyaltyPointsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}/adjust"),
            [new TemplateParam("account_id", accountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AdjustLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CalculateLoyaltyPoints
    /// </summary>
    /// <param name="programId">The ID of the <see href="entity:LoyaltyProgram">loyalty program</see>, which defines the rules for accruing points.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculates the number of points a buyer can earn from a purchase. Applications might call this endpoint
    /// to display the points to the buyer.
    /// <para>
    /// - If you are using the Orders API to manage orders, provide the <c>order_id</c> and (optional) <c>loyalty_account_id</c>.
    /// Square reads the order to compute the points earned from the base loyalty program and an associated
    /// <see href="entity:LoyaltyPromotion">loyalty promotion</see>.
    /// </para>
    /// <para>
    /// - If you are not using the Orders API to manage orders, provide <c>transaction_amount_money</c> with the
    /// purchase amount. Square uses this amount to calculate the points earned from the base loyalty program,
    /// but not points earned from a loyalty promotion. For spend-based and visit-based programs, the <c>tax_mode</c>
    /// setting of the accrual rule indicates how taxes should be treated for loyalty points accrual.
    /// If the purchase qualifies for program points, call
    /// <see href="api-endpoint:Loyalty-ListLoyaltyPromotions">ListLoyaltyPromotions</see> and perform a client-side computation
    /// to calculate whether the purchase also qualifies for promotion points. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-promotions#calculate-promotion-points">Calculating promotion points</see>.
    /// </para>
    /// </remarks>
    public Task<CalculateLoyaltyPointsResponse> CalculateLoyaltyPoints(string programId,
        CalculateLoyaltyPointsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/calculate"),
            [new TemplateParam("program_id", programId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculateLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CancelLoyaltyPromotion
    /// </summary>
    /// <param name="promotionId">The ID of the <see href="entity:LoyaltyPromotion">loyalty promotion</see> to cancel. You can cancel a promotion that has an <c>ACTIVE</c> or <c>SCHEDULED</c> status.</param>
    /// <param name="programId">The ID of the base <see href="entity:LoyaltyProgram">loyalty program</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelLoyaltyPromotionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a loyalty promotion. Use this endpoint to cancel an <c>ACTIVE</c> promotion earlier than the
    /// end date, cancel an <c>ACTIVE</c> promotion when an end date is not specified, or cancel a <c>SCHEDULED</c> promotion.
    /// Because updating a promotion is not supported, you can also use this endpoint to cancel a promotion before
    /// you create a new one.
    /// <para>
    /// This endpoint sets the loyalty promotion to the <c>CANCELED</c> state
    /// </para>
    /// </remarks>
    public Task<CancelLoyaltyPromotionResponse> CancelLoyaltyPromotion(string promotionId,
        string programId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/promotions/{promotion_id}/cancel"),
            [new TemplateParam("promotion_id", promotionId), new TemplateParam("program_id", programId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelLoyaltyPromotionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateLoyaltyAccount
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLoyaltyAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a loyalty account. To create a loyalty account, you must provide the <c>program_id</c> and a <c>mapping</c> with the <c>phone_number</c> of the buyer.
    /// </remarks>
    public Task<CreateLoyaltyAccountResponse> CreateLoyaltyAccount(CreateLoyaltyAccountRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLoyaltyAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateLoyaltyPromotion
    /// </summary>
    /// <param name="programId">The ID of the <see href="entity:LoyaltyProgram">loyalty program</see> to associate with the promotion. To get the program ID, call <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLoyaltyPromotionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a loyalty promotion for a <see href="entity:LoyaltyProgram">loyalty program</see>. A loyalty promotion
    /// enables buyers to earn points in addition to those earned from the base loyalty program.
    /// <para>
    /// This endpoint sets the loyalty promotion to the <c>ACTIVE</c> or <c>SCHEDULED</c> status, depending on the
    /// <c>available_time</c> setting. A loyalty program can have a maximum of 10 loyalty promotions with an
    /// <c>ACTIVE</c> or <c>SCHEDULED</c> status.
    /// </para>
    /// </remarks>
    public Task<CreateLoyaltyPromotionResponse> CreateLoyaltyPromotion(string programId,
        CreateLoyaltyPromotionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/promotions"),
            [new TemplateParam("program_id", programId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLoyaltyPromotionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// CreateLoyaltyReward
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a loyalty reward. In the process, the endpoint does following:
    /// <para>
    /// - Uses the <c>reward_tier_id</c> in the request to determine the number of points
    /// to lock for this reward.
    /// - If the request includes <c>order_id</c>, it adds the reward and related discount to the order.
    /// </para>
    /// <para>
    /// After a reward is created, the points are locked and
    /// not available for the buyer to redeem another reward.
    /// </para>
    /// </remarks>
    public Task<CreateLoyaltyRewardResponse> CreateLoyaltyReward(CreateLoyaltyRewardRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// DeleteLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a loyalty reward by doing the following:
    /// <para>
    /// - Returns the loyalty points back to the loyalty account.
    /// - If an order ID was specified when the reward was created
    /// (see <see href="api-endpoint:Loyalty-CreateLoyaltyReward">CreateLoyaltyReward</see>),
    /// it updates the order by removing the reward and related
    /// discounts.
    /// </para>
    /// <para>
    /// You cannot delete a reward that has reached the terminal state (REDEEMED).
    /// </para>
    /// </remarks>
    public Task<DeleteLoyaltyRewardResponse> DeleteLoyaltyReward(string rewardId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListLoyaltyPrograms
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLoyaltyProgramsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of loyalty programs in the seller's account.
    /// Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// <para>
    ///
    /// Replaced with <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> when used with the keyword <c>main</c>.
    /// </para>
    /// </remarks>
    public Task<ListLoyaltyProgramsResponse> ListLoyaltyPrograms(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLoyaltyProgramsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// ListLoyaltyPromotions
    /// </summary>
    /// <param name="programId">The ID of the base <see href="entity:LoyaltyProgram">loyalty program</see>. To get the program ID, call <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.</param>
    /// <param name="status">The status to filter the results by. If a status is provided, only loyalty promotions with the specified status are returned. Otherwise, all loyalty promotions associated with the loyalty program are returned.</param>
    /// <param name="cursor">The cursor returned in the paged response from the previous call to this endpoint. Provide this cursor to retrieve the next page of results for your original request. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single paged response. The minimum value is 1 and the maximum value is 30. The default value is 30. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLoyaltyPromotionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the loyalty promotions associated with a <see href="entity:LoyaltyProgram">loyalty program</see>.
    /// Results are sorted by the <c>created_at</c> date in descending order (newest to oldest).
    /// </remarks>
    public Task<ListLoyaltyPromotionsResponse> ListLoyaltyPromotions(string programId,
        LoyaltyPromotionStatus? status,
        string? cursor,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/promotions"),
            [new TemplateParam("program_id", programId)],
            [new Param("status", status), new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLoyaltyPromotionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RedeemLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to redeem.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RedeemLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Redeems a loyalty reward.
    /// <para>
    /// The endpoint sets the reward to the <c>REDEEMED</c> terminal state.
    /// </para>
    /// <para>
    /// If you are using your own order processing system (not using the
    /// Orders API), you call this endpoint after the buyer paid for the
    /// purchase.
    /// </para>
    /// <para>
    /// After the reward reaches the terminal state, it cannot be deleted.
    /// In other words, points used for the reward cannot be returned
    /// to the account.
    /// </para>
    /// </remarks>
    public Task<RedeemLoyaltyRewardResponse> RedeemLoyaltyReward(string rewardId,
        RedeemLoyaltyRewardRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}/redeem"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RedeemLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveLoyaltyAccount
    /// </summary>
    /// <param name="accountId">The ID of the <see href="entity:LoyaltyAccount">loyalty account</see> to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a loyalty account.
    /// </remarks>
    public Task<RetrieveLoyaltyAccountResponse> RetrieveLoyaltyAccount(string accountId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}"),
            [new TemplateParam("account_id", accountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveLoyaltyProgram
    /// </summary>
    /// <param name="programId">The ID of the loyalty program or the keyword <c>main</c>. Either value can be used to retrieve the single loyalty program that belongs to the seller.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyProgramResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the loyalty program in a seller's account, specified by the program ID or the keyword <c>main</c>.
    /// <para>
    /// Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// </para>
    /// </remarks>
    public Task<RetrieveLoyaltyProgramResponse> RetrieveLoyaltyProgram(string programId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}"),
            [new TemplateParam("program_id", programId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyProgramResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveLoyaltyPromotion
    /// </summary>
    /// <param name="promotionId">The ID of the <see href="entity:LoyaltyPromotion">loyalty promotion</see> to retrieve.</param>
    /// <param name="programId">The ID of the base <see href="entity:LoyaltyProgram">loyalty program</see>. To get the program ID, call <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyPromotionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a loyalty promotion.
    /// </remarks>
    public Task<RetrieveLoyaltyPromotionResponse> RetrieveLoyaltyPromotion(string promotionId,
        string programId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/promotions/{promotion_id}"),
            [new TemplateParam("promotion_id", promotionId), new TemplateParam("program_id", programId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyPromotionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// RetrieveLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="entity:LoyaltyReward">loyalty reward</see> to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a loyalty reward.
    /// </remarks>
    public Task<RetrieveLoyaltyRewardResponse> RetrieveLoyaltyReward(string rewardId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchLoyaltyAccounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyAccountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty accounts in a loyalty program.
    /// <para>
    /// You can search for a loyalty account using the phone number or customer ID associated with the account. To return all loyalty accounts, specify an empty <c>query</c> object or omit it entirely.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>created_at</c> in ascending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyAccountsResponse> SearchLoyaltyAccounts(SearchLoyaltyAccountsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyAccountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchLoyaltyEvents
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyEventsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty events.
    /// <para>
    /// A Square loyalty program maintains a ledger of events that occur during the lifetime of a
    /// buyer's loyalty account. Each change in the point balance
    /// (for example, points earned, points redeemed, and points expired) is
    /// recorded in the ledger. Using this endpoint, you can search the ledger for events.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>created_at</c> in descending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyEventsResponse> SearchLoyaltyEvents(SearchLoyaltyEventsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/events/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);

    /// <summary>
    /// SearchLoyaltyRewards
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyRewardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty rewards. This endpoint accepts a request with no query filters and returns results for all loyalty accounts.
    /// If you include a <c>query</c> object, <c>loyalty_account_id</c> is required and <c>status</c> is  optional.
    /// <para>
    /// If you know a reward ID, use the
    /// <see href="api-endpoint:Loyalty-RetrieveLoyaltyReward">RetrieveLoyaltyReward</see> endpoint.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>updated_at</c> in descending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyRewardsResponse> SearchLoyaltyRewards(SearchLoyaltyRewardsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyRewardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            ct);
}
