using System.Text.Json.Serialization;

namespace Square.Models;

public record BankAccountVerifiedEventObject
{
    /// <summary>
    /// Represents a bank account. For more information about
    /// linking a bank account to a Square account, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public BankAccount? BankAccount { get; init; }
}
