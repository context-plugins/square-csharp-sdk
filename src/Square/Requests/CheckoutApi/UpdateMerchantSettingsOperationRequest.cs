using Square.Models;

namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the UpdateMerchantSettings operation.
/// </summary>
public sealed record UpdateMerchantSettingsOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateMerchantSettingsRequest Body { get; init; }
}
