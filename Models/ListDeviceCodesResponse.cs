using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record ListDeviceCodesResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The queried DeviceCode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_codes")]
    public IReadOnlyList<DeviceCode>? DeviceCodes { get; init; }

    /// <summary>
    /// A pagination cursor to retrieve the next set of results for your
    /// original query to the endpoint. This value is present only if the request
    /// succeeded and additional results are available.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
