using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// The response to a request for a set of <c>EmployeeWage</c> objects. The response contains
/// a set of <c>EmployeeWage</c> objects.
/// </summary>
public record ListEmployeeWagesResponse
{
    /// <summary>
    /// A page of <c>EmployeeWage</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_wages")]
    public IReadOnlyList<EmployeeWage>? EmployeeWages { get; init; }

    /// <summary>
    /// The value supplied in the subsequent request to fetch the next page
    /// of <c>EmployeeWage</c> results.
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
