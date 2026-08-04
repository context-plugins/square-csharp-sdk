using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record Device
{
    /// <summary>
    /// A synthetic identifier for the device. The identifier includes a standardized prefix and
    /// is otherwise an opaque id generated from key device fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("attributes")]
    public required DeviceAttributes Attributes { get; init; }

    /// <summary>
    /// A list of components applicable to the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("components")]
    public IReadOnlyList<Component?>? Components { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public DeviceStatus? Status { get; init; }
}
