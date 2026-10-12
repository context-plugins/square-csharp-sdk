using Square.Models;

namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the CreateCheckout operation.
/// </summary>
public sealed record CreateCheckoutOperationRequest
{
    /// <summary>
    /// The ID of the business location to associate the checkout with.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateCheckoutRequest Body { get; init; }
}
