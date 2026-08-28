using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents the details of a tender with <c>type</c> <c>BANK_ACCOUNT</c>.
/// <para>
/// See <see href="entity:BankAccountPaymentDetails">BankAccountPaymentDetails</see>
/// for more exposed details of a bank account payment.
/// </para>
/// </summary>
public record TenderBankAccountDetails
{
    /// <summary>
    /// Indicates the bank account payment's current status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public TenderBankAccountDetailsStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
