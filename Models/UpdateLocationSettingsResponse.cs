using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateLocationSettingsResponse
{
    /// <summary>
    /// Any errors that occurred when updating the location settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_settings")]
    public CheckoutLocationSettings? LocationSettings { get; init; }
}
