using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:BookingCustomAttributes-UpsertBookingCustomAttribute">UpsertBookingCustomAttribute</see> response.
/// Either <c>custom_attribute_definition</c> or <c>errors</c> is present in the response.
/// </summary>
public record UpsertBookingCustomAttributeResponse
{
    /// <summary>
    /// A custom attribute value. Each custom attribute value has a corresponding
    /// <c>CustomAttributeDefinition</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute")]
    public CustomAttribute? CustomAttribute { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
