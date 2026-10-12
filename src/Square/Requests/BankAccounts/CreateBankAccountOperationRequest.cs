using Square.Models;

namespace Square.Requests.BankAccounts;

/// <summary>
/// The inputs of the CreateBankAccount operation.
/// </summary>
public sealed record CreateBankAccountOperationRequest
{
    /// <summary>
    /// An object containing the fields to POST for the request.
    /// <para>
    /// See the corresponding object definition for field details.
    /// </para>
    /// </summary>
    public required CreateBankAccountRequest Body { get; init; }
}
