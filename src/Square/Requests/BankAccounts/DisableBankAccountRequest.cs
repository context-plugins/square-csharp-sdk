namespace Square.Requests.BankAccounts;

/// <summary>
/// The inputs of the DisableBankAccount operation.
/// </summary>
public sealed record DisableBankAccountRequest
{
    /// <summary>
    /// The ID of the bank account to disable.
    /// </summary>
    public required string BankAccountId { get; init; }
}
