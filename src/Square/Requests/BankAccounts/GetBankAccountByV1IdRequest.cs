namespace Square.Requests.BankAccounts;

/// <summary>
/// The inputs of the GetBankAccountByV1Id operation.
/// </summary>
public sealed record GetBankAccountByV1IdRequest
{
    /// <summary>
    /// Connect V1 ID of the desired <c>BankAccount</c>. For more information, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api#retrieve-a-bank-account-by-using-an-id-issued-by-v1-bank-accounts-api">Retrieve a bank account by using an ID issued by V1 Bank Accounts API</see>.
    /// </summary>
    public required string V1BankAccountId { get; init; }
}
