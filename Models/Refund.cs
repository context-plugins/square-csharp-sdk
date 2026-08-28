using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a refund processed for a Square transaction.
/// </summary>
public record Refund
{
    /// <summary>
    /// The refund's unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public required string Id { get; init; }

    /// <summary>
    /// The ID of the refund's associated location.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MaxLength(50)]
    public required string LocationId { get; init; }

    /// <summary>
    /// The ID of the transaction that the refunded tender is part of.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_id")]
    [MaxLength(192)]
    public string? TransactionId { get; init; }

    /// <summary>
    /// The ID of the refunded tender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tender_id")]
    [MaxLength(192)]
    public string? TenderId { get; init; }

    /// <summary>
    /// The timestamp for when the refund was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(32)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The reason for the refund being issued.
    /// </summary>
    [JsonPropertyName("reason")]
    [MaxLength(192)]
    public required string Reason { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    /// <summary>
    /// Indicates a refund's current status.
    /// </summary>
    [JsonPropertyName("status")]
    public required RefundStatus Status { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_fee_money")]
    public Money? ProcessingFeeMoney { get; init; }

    /// <summary>
    /// Additional recipients (other than the merchant) receiving a portion of this refund.
    /// For example, fees assessed on a refund of a purchase by a third party integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additional_recipients")]
    public IReadOnlyList<AdditionalRecipient?>? AdditionalRecipients { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
