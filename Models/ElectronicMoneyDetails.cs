using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Details specific to electronic money payments.
/// </summary>
public record ElectronicMoneyDetails
{
    /// <summary>
    /// Details for Felica payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("felica_details")]
    public FelicaDetails? FelicaDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
