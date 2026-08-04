using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents an additional recipient (other than the merchant) receiving a portion of this tender.
/// </summary>
public record AdditionalRecipient
{
    /// <summary>
    /// The location ID for a recipient (other than the merchant) receiving a portion of this tender.
    /// </summary>
    [JsonPropertyName("location_id")]
    [StringLength(50, MinimumLength = 1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// The description of the additional recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(100)]
    public string? Description { get; init; }

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
    /// The unique ID for the RETIRED <c>AdditionalRecipientReceivable</c> object. This field should be empty for any <c>AdditionalRecipient</c> objects created after the retirement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receivable_id")]
    [MaxLength(192)]
    public string? ReceivableId { get; init; }
}
