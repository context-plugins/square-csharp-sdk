using Square.Models.Enums;

namespace Square.Requests.V1Transactions;

/// <summary>
/// The inputs of the V1ListOrders operation.
/// </summary>
public sealed record V1ListOrdersRequest
{
    /// <summary>
    /// The ID of the location to list online store orders for.
    /// </summary>
    public required string LocationId { get; init; }

    /// <summary>
    /// The order in which payments are listed in the response.
    /// </summary>
    public SortOrder? Order { get; init; }

    /// <summary>
    /// The maximum number of payments to return in a single response. This value cannot exceed 200.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// A pagination cursor to retrieve the next set of results for your
    /// original query to the endpoint.
    /// </summary>
    public string? BatchToken { get; init; }
}
