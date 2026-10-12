using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a response from listing order custom attributes.
/// </summary>
public record ListOrderCustomAttributesResponse
{
    /// <summary>
    /// The retrieved custom attributes. If no custom attribute are found, Square returns an empty object (<c>{}</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attributes")]
    public IReadOnlyList<CustomAttribute>? CustomAttributes { get; init; }

    /// <summary>
    /// The cursor to provide in your next call to this endpoint to retrieve the next page of results for your original request.
    /// This field is present only if the request succeeded and additional results are available.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MinLength(1)]
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
