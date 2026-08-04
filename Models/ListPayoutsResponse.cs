using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The response to retrieve payout records entries.
/// </summary>
public record ListPayoutsResponse
{
    /// <summary>
    /// The requested list of payouts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payouts")]
    public IReadOnlyList<Payout>? Payouts { get; init; }

    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If empty, this is the final response.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
