using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="api-endpoint:ApplePay-RegisterDomain">RegisterDomain</see> endpoint.
/// <para>
/// Either <c>errors</c> or <c>status</c> are present in a given response (never both).
/// </para>
/// </summary>
public record RegisterDomainResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The status of the domain registration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public RegisterDomainResponseStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
