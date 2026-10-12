using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Additional details about <c>WALLET</c> type payments. Contains only non-confidential information.
/// </summary>
public record DigitalWalletDetails
{
    /// <summary>
    /// The status of the <c>WALLET</c> payment. The status can be <c>AUTHORIZED</c>, <c>CAPTURED</c>, <c>VOIDED</c>, or
    /// <c>FAILED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [MaxLength(50)]
    public string? Status { get; init; }

    /// <summary>
    /// The brand used for the <c>WALLET</c> payment. The brand can be <c>CASH_APP</c>, <c>PAYPAY</c>, <c>ALIPAY</c>,
    /// <c>RAKUTEN_PAY</c>, <c>AU_PAY</c>, <c>D_BARAI</c>, <c>MERPAY</c>, <c>WECHAT_PAY</c>, <c>LIGHTNING</c> or <c>UNKNOWN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    [MaxLength(50)]
    public string? Brand { get; init; }

    /// <summary>
    /// Additional details about <c>WALLET</c> type payments with the <c>brand</c> of <c>CASH_APP</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_app_details")]
    public CashAppDetails? CashAppDetails { get; init; }

    /// <summary>
    /// Additional details about <c>WALLET</c> type payments with the <c>brand</c> of <c>LIGHTNING</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lightning_details")]
    public LightningDetails? LightningDetails { get; init; }

    /// <summary>
    /// Information about errors encountered during the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
