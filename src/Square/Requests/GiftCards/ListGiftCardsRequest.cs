namespace Square.Requests.GiftCards;

/// <summary>
/// The inputs of the ListGiftCards operation.
/// </summary>
public sealed record ListGiftCardsRequest
{
    /// <summary>
    /// If a <see href="entity:GiftCardType">type</see> is provided, the endpoint returns gift cards of the specified type.
    /// Otherwise, the endpoint returns gift cards of all types.
    /// </summary>
    public string? Type { get; init; }

    /// <summary>
    /// If a <see href="entity:GiftCardStatus">state</see> is provided, the endpoint returns the gift cards in the specified state.
    /// Otherwise, the endpoint returns the gift cards of all states.
    /// </summary>
    public string? State { get; init; }

    /// <summary>
    /// If a limit is provided, the endpoint returns only the specified number of results per page.
    /// The maximum value is 200. The default value is 30.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// If a cursor is not provided, the endpoint returns the first page of the results.
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// If a customer ID is provided, the endpoint returns only the gift cards linked to the specified customer.
    /// </summary>
    public string? CustomerId { get; init; }
}
