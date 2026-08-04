using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Additional details about a Buy Now Pay Later payment type.
/// </summary>
public record BuyNowPayLaterDetails
{
    /// <summary>
    /// The brand used for the Buy Now Pay Later payment.
    /// The brand can be <c>AFTERPAY</c>, <c>CLEARPAY</c> or <c>UNKNOWN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    [MaxLength(50)]
    public string? Brand { get; init; }

    /// <summary>
    /// Additional details about Afterpay payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("afterpay_details")]
    public AfterpayDetails? AfterpayDetails { get; init; }

    /// <summary>
    /// Additional details about Clearpay payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clearpay_details")]
    public ClearpayDetails? ClearpayDetails { get; init; }

    /// <summary>
    /// Information about errors encountered during the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
