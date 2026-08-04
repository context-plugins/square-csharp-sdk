using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Additional details about Afterpay payments.
/// </summary>
public record AfterpayDetails
{
    /// <summary>
    /// Email address on the buyer's Afterpay account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [MaxLength(255)]
    public string? EmailAddress { get; init; }
}
