using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Loyalty-ListLoyaltyPromotions">ListLoyaltyPromotions</see> response.
/// One of <c>loyalty_promotions</c>, an empty object, or <c>errors</c> is present in the response.
/// If additional results are available, the <c>cursor</c> field is also present along with <c>loyalty_promotions</c>.
/// </summary>
public record ListLoyaltyPromotionsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The retrieved loyalty promotions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_promotions")]
    public IReadOnlyList<LoyaltyPromotion>? LoyaltyPromotions { get; init; }

    /// <summary>
    /// The cursor to use in your next call to this endpoint to retrieve the next page of results
    /// for your original request. This field is present only if the request succeeded and additional
    /// results are available. For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
