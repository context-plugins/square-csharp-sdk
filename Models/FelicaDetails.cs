using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Details for Felica payments.
/// </summary>
public record FelicaDetails
{
    /// <summary>
    /// The terminal id for a Felica payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminal_id")]
    [MaxLength(255)]
    public string? TerminalId { get; init; }

    /// <summary>
    /// The masked card number for a Felica payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("felica_masked_card_number")]
    public string? FelicaMaskedCardNumber { get; init; }

    /// <summary>
    /// A Felica card's "sub-brand"--the actual brand on the Felica card
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("felica_brand")]
    public FelicaDetailsFelicaBrand? FelicaBrand { get; init; }
}
