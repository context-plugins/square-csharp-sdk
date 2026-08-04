using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:LocationCustomAttributes-ListLocationCustomAttributeDefinitions">ListLocationCustomAttributeDefinitions</see> response.
/// Either <c>custom_attribute_definitions</c>, an empty object, or <c>errors</c> is present in the response.
/// If additional results are available, the <c>cursor</c> field is also present along with <c>custom_attribute_definitions</c>.
/// </summary>
public record ListLocationCustomAttributeDefinitionsResponse
{
    /// <summary>
    /// The retrieved custom attribute definitions. If no custom attribute definitions are found,
    /// Square returns an empty object (<c>{}</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definitions")]
    public IReadOnlyList<CustomAttributeDefinition>? CustomAttributeDefinitions { get; init; }

    /// <summary>
    /// The cursor to provide in your next call to this endpoint to retrieve the next page of
    /// results for your original request. This field is present only if the request succeeded and
    /// additional results are available. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
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
}
