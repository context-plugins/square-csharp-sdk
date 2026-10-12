using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:BookingCustomAttributes-ListBookingCustomAttributes">ListBookingCustomAttributes</see> response.
/// Either <c>custom_attributes</c>, an empty object, or <c>errors</c> is present in the response. If additional
/// results are available, the <c>cursor</c> field is also present along with <c>custom_attributes</c>.
/// </summary>
public record ListBookingCustomAttributesResponse
{
    /// <summary>
    /// The retrieved custom attributes. If <c>with_definitions</c> was set to <c>true</c> in the request,
    /// the custom attribute definition is returned in the <c>definition</c> field of each custom attribute.
    /// <para>
    /// If no custom attributes are found, Square returns an empty object (<c>{}</c>).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attributes")]
    public IReadOnlyList<CustomAttribute>? CustomAttributes { get; init; }

    /// <summary>
    /// The cursor to use in your next call to this endpoint to retrieve the next page of results
    /// for your original request. This field is present only if the request succeeded and additional
    /// results are available. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
