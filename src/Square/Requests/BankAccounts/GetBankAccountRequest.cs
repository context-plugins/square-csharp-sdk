namespace Square.Requests.BankAccounts;

/// <summary>
/// The inputs of the GetBankAccount operation.
/// </summary>
public sealed record GetBankAccountRequest
{
    /// <summary>
    /// Square-issued ID of the desired <c>BankAccount</c>.
    /// </summary>
    public required string BankAccountId { get; init; }
}
