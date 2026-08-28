using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The request object for the <see href="api-endpoint:Locations-UpdateLocation">UpdateLocation</see> endpoint.
/// </summary>
public record UpdateLocationRequest
{
    /// <summary>
    /// Represents one of a business' <see href="https://developer.squareup.com/docs/locations-api">locations</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
