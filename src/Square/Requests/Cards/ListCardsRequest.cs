using Square.Models.Enums;

namespace Square.Requests.Cards;

/// <summary>
/// The inputs of the ListCards operation.
/// </summary>
public sealed record ListCardsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/pagination">Pagination</see> for more information.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Limit results to cards associated with the customer supplied.
    /// By default, all cards owned by the merchant are returned.
    /// </summary>
    public string? CustomerId { get; init; }

    /// <summary>
    /// Includes disabled cards.
    /// By default, all enabled cards owned by the merchant are returned.
    /// </summary>
    public bool IncludeDisabled { get; init; } = false;

    /// <summary>
    /// Limit results to cards associated with the reference_id supplied.
    /// </summary>
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Sorts the returned list by when the card was created with the specified order.
    /// This field defaults to ASC.
    /// </summary>
    public SortOrder? SortOrder { get; init; }
}
