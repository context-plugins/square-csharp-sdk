using Square.Models.Enums;

namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the ListLoyaltyPromotions operation.
/// </summary>
public sealed record ListLoyaltyPromotionsRequest
{
    /// <summary>
    /// The ID of the base <see href="entity:LoyaltyProgram">loyalty program</see>. To get the program ID,
    /// call <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.
    /// </summary>
    public required string ProgramId { get; init; }

    /// <summary>
    /// The status to filter the results by. If a status is provided, only loyalty promotions
    /// with the specified status are returned. Otherwise, all loyalty promotions associated with
    /// the loyalty program are returned.
    /// </summary>
    public LoyaltyPromotionStatus? Status { get; init; }

    /// <summary>
    /// The cursor returned in the paged response from the previous call to this endpoint.
    /// Provide this cursor to retrieve the next page of results for your original request.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single paged response.
    /// The minimum value is 1 and the maximum value is 30. The default value is 30.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see>.
    /// </summary>
    public int? Limit { get; init; }
}
