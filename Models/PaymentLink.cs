using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Validation.Attributes;

namespace Square.Models;

public record PaymentLink
{
    /// <summary>
    /// The Square-assigned ID of the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The Square-assigned version number, which is incremented each time an update is committed to the payment link.
    /// </summary>
    [JsonPropertyName("version")]
    [Maximum(65535)]
    public required int Version { get; init; }

    /// <summary>
    /// The optional description of the <c>payment_link</c> object.
    /// It is primarily for use by your application and is not used anywhere.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(4096)]
    public string? Description { get; init; }

    /// <summary>
    /// The ID of the order associated with the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    [MaxLength(192)]
    public string? OrderId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout_options")]
    public CheckoutOptions? CheckoutOptions { get; init; }

    /// <summary>
    /// Describes buyer data to prepopulate in the payment form.
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/checkout-api/optional-checkout-configurations">Optional Checkout Configurations</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_populated_data")]
    public PrePopulatedData? PrePopulatedData { get; init; }

    /// <summary>
    /// The shortened URL of the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [MaxLength(255)]
    public string? Url { get; init; }

    /// <summary>
    /// The long URL of the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long_url")]
    [MaxLength(255)]
    public string? LongUrl { get; init; }

    /// <summary>
    /// The timestamp when the payment link was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the payment link was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// An optional note. After Square processes the payment, this note is added to the
    /// resulting <c>Payment</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_note")]
    [MaxLength(500)]
    public string? PaymentNote { get; init; }
}
