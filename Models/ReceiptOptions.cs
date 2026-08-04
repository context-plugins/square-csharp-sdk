using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes receipt action fields.
/// </summary>
public record ReceiptOptions
{
    /// <summary>
    /// The reference to the Square payment ID for the receipt.
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// Instructs the device to print the receipt without displaying the receipt selection screen.
    /// Requires <c>printer_enabled</c> set to true.
    /// Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("print_only")]
    public bool? PrintOnly { get; init; }

    /// <summary>
    /// Identify the receipt as a reprint rather than an original receipt.
    /// Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_duplicate")]
    public bool? IsDuplicate { get; init; }
}
