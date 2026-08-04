using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record ListPaymentLinksResponse
{
    /// <summary>
    /// Errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The list of payment links.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_links")]
    public IReadOnlyList<PaymentLink>? PaymentLinks { get; init; }

    /// <summary>
    /// When a response is truncated, it includes a cursor that you can use in a subsequent request
    /// to retrieve the next set of gift cards. If a cursor is not present, this is the final response.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}
