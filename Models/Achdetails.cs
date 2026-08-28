using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// ACH-specific details about <c>BANK_ACCOUNT</c> type payments with the <c>transfer_type</c> of <c>ACH</c>.
/// </summary>
public record AchDetails
{
    /// <summary>
    /// The routing number for the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_number")]
    [MaxLength(50)]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// The last few digits of the bank account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_number_suffix")]
    [StringLength(4, MinimumLength = 1)]
    public string? AccountNumberSuffix { get; init; }

    /// <summary>
    /// The type of the bank account performing the transfer. The account type can be <c>CHECKING</c>,
    /// <c>SAVINGS</c>, or <c>UNKNOWN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_type")]
    [MaxLength(50)]
    public string? AccountType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
