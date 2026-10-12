using Square.Models;

namespace Square.Requests.ApplePay;

/// <summary>
/// The inputs of the RegisterDomain operation.
/// </summary>
public sealed record RegisterDomainOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required RegisterDomainRequest Body { get; init; }
}
