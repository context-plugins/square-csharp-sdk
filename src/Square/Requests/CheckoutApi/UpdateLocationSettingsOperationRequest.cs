using Square.Models;

namespace Square.Requests.CheckoutApi;

/// <summary>
/// The inputs of the UpdateLocationSettings operation.
/// </summary>
public sealed record UpdateLocationSettingsOperationRequest
{
    /// <summary>
    /// The ID of the location for which to retrieve settings.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required UpdateLocationSettingsRequest Body { get; init; }
}
