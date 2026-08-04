using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record RetrieveLocationSettingsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_settings")]
    public CheckoutLocationSettings? LocationSettings { get; init; }
}
