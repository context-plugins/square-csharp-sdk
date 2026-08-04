using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record GetDeviceCodeResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_code")]
    public DeviceCode? DeviceCode { get; init; }
}
