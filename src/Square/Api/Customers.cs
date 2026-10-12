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
using Square.Requests.Customers;

namespace Square.Api;

public sealed class Customers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Customers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AddGroupToCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AddGroupToCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a group membership to a customer.
    /// <para>
    /// The customer is identified by the <c>customer_id</c> value
    /// and the customer group is identified by the <c>group_id</c> value.
    /// </para>
    /// </remarks>
    public Task<AddGroupToCustomerResponse> AddGroupToCustomer(AddGroupToCustomerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/groups/{group_id}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("group_id", request.GroupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<AddGroupToCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkCreateCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkCreateCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates multiple <see href="entity:Customer">customer profiles</see> for a business.
    /// <para>
    /// This endpoint takes a map of individual create requests and returns a map of responses.
    /// </para>
    /// <para>
    /// You must provide at least one of the following values in each create request:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>given_name</c></description></item>
    ///   <item><description><c>family_name</c></description></item>
    ///   <item><description><c>company_name</c></description></item>
    ///   <item><description><c>email_address</c></description></item>
    ///   <item><description><c>phone_number</c></description></item>
    /// </list>
    /// </remarks>
    public Task<BulkCreateCustomersResponse> BulkCreateCustomers(BulkCreateCustomersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/bulk-create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkCreateCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkDeleteCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkDeleteCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes multiple customer profiles.
    /// <para>
    /// The endpoint takes a list of customer IDs and returns a map of responses.
    /// </para>
    /// </remarks>
    public Task<BulkDeleteCustomersResponse> BulkDeleteCustomers(BulkDeleteCustomersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/bulk-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkDeleteCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkRetrieveCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkRetrieveCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves multiple customer profiles.
    /// <para>
    /// This endpoint takes a list of customer IDs and returns a map of responses.
    /// </para>
    /// </remarks>
    public Task<BulkRetrieveCustomersResponse> BulkRetrieveCustomers(BulkRetrieveCustomersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/bulk-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkRetrieveCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// BulkUpdateCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpdateCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates multiple customer profiles.
    /// <para>
    /// This endpoint takes a map of individual update requests and returns a map of responses.
    /// </para>
    /// </remarks>
    public Task<BulkUpdateCustomersResponse> BulkUpdateCustomers(BulkUpdateCustomersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/bulk-update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BulkUpdateCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new customer for a business.
    /// <para>
    /// You must provide at least one of the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>given_name</c></description></item>
    ///   <item><description><c>family_name</c></description></item>
    ///   <item><description><c>company_name</c></description></item>
    ///   <item><description><c>email_address</c></description></item>
    ///   <item><description><c>phone_number</c></description></item>
    /// </list>
    /// </remarks>
    public Task<CreateCustomerResponse> CreateCustomer(CreateCustomerOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// CreateCustomerCard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerCardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a card on file to an existing customer.
    /// <para>
    /// As with charges, calls to <c>CreateCustomerCard</c> are idempotent. Multiple
    /// calls with the same card nonce return the same card record that was created
    /// with the provided nonce during the _first_ call.
    /// </para>
    /// </remarks>
    public Task<CreateCustomerCardResponse> CreateCustomerCard(CreateCustomerCardOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/cards"),
            [new TemplateParam("customer_id", request.CustomerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCustomerCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a customer profile from a business.
    /// <para>
    /// To delete a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.
    /// </para>
    /// </remarks>
    public Task<DeleteCustomerResponse> DeleteCustomer(DeleteCustomerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", request.CustomerId)],
            [new Param("version", request.Version)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// DeleteCustomerCard
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCardResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a card on file from a customer.
    /// </remarks>
    public Task<DeleteCustomerCardResponse> DeleteCustomerCard(DeleteCustomerCardRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/cards/{card_id}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("card_id", request.CardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// ListCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists customer profiles associated with a Square account.
    /// <para>
    /// Under normal operating conditions, newly created or updated customer profiles become available
    /// for the listing operation in well under 30 seconds. Occasionally, propagation of the new or updated
    /// profiles can take closer to one minute or longer, especially during network incidents and outages.
    /// </para>
    /// </remarks>
    public Task<ListCustomersResponse> ListCustomers(ListCustomersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers"),
            [],
            [
                new Param("cursor", request.Cursor),
                new Param("limit", request.Limit),
                new Param("sort_field", request.SortField),
                new Param("sort_order", request.SortOrder),
                new Param("count", request.Count),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RemoveGroupFromCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemoveGroupFromCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a group membership from a customer.
    /// <para>
    /// The customer is identified by the <c>customer_id</c> value
    /// and the customer group is identified by the <c>group_id</c> value.
    /// </para>
    /// </remarks>
    public Task<RemoveGroupFromCustomerResponse> RemoveGroupFromCustomer(RemoveGroupFromCustomerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}/groups/{group_id}"),
            [new TemplateParam("customer_id", request.CustomerId), new TemplateParam("group_id", request.GroupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<RemoveGroupFromCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// RetrieveCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for a single customer.
    /// </remarks>
    public Task<RetrieveCustomerResponse> RetrieveCustomer(RetrieveCustomerRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", request.CustomerId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// SearchCustomers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCustomersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches the customer profiles associated with a Square account using one or more supported query filters.
    /// <para>
    /// Calling <c>SearchCustomers</c> without any explicit query filter returns all
    /// customer profiles ordered alphabetically based on <c>given_name</c> and
    /// <c>family_name</c>.
    /// </para>
    /// <para>
    /// Under normal operating conditions, newly created or updated customer profiles become available
    /// for the search operation in well under 30 seconds. Occasionally, propagation of the new or updated
    /// profiles can take closer to one minute or longer, especially during network incidents and outages.
    /// </para>
    /// </remarks>
    public Task<SearchCustomersResponse> SearchCustomers(SearchCustomersOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SearchCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// UpdateCustomer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a customer profile. This endpoint supports sparse updates, so only new or changed fields are required in the request.
    /// To add or update a field, specify the new value. To remove a field, specify <c>null</c>.
    /// <para>
    /// To update a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.
    /// </para>
    /// </remarks>
    public Task<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerOperationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", request.CustomerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            requestOptions,
            cancellationToken);
}
