using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the parameters that can be included in the body of
/// a request to the <see href="api-endpoint:ApplePay-RegisterDomain">RegisterDomain</see> endpoint.
/// </summary>
public record RegisterDomainRequest
{
    /// <summary>
    /// A domain name as described in RFC-1034 that will be registered with ApplePay.
    /// </summary>
    [JsonPropertyName("domain_name")]
    [StringLength(255, MinimumLength = 1)]
    public required string DomainName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
