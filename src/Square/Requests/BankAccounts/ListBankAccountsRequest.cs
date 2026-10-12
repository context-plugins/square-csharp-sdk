namespace Square.Requests.BankAccounts;

/// <summary>
/// The inputs of the ListBankAccounts operation.
/// </summary>
public sealed record ListBankAccountsRequest
{
    /// <summary>
    /// The pagination cursor returned by a previous call to this endpoint.
    /// Use it in the next <c>ListBankAccounts</c> request to retrieve the next set
    /// of results.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Upper limit on the number of bank accounts to return in the response.
    /// Currently, 1000 is the largest supported limit. You can specify a limit
    /// of up to 1000 bank accounts. This is also the default limit.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Location ID. You can specify this optional filter
    /// to retrieve only the linked bank accounts belonging to a specific location.
    /// </summary>
    public string? LocationId { get; init; }

    /// <summary>
    /// Customer ID. You can specify this optional filter
    /// to retrieve only the linked bank accounts belonging to a specific customer.
    /// </summary>
    public string? CustomerId { get; init; }
}
