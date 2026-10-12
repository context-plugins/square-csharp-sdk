using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record BankAccountDisabledEventObject
{
    /// <summary>
    /// Represents a bank account. For more information about
    /// linking a bank account to a Square account, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public BankAccount? BankAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
