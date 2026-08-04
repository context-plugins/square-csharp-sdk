using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Identifiers for the location used by various governments for tax purposes.
/// </summary>
public record TaxIds
{
    /// <summary>
    /// The EU VAT number for this location. For example, <c>IE3426675K</c>.
    /// If the EU VAT number is present, it is well-formed and has been
    /// validated with VIES, the VAT Information Exchange System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eu_vat")]
    public string? EuVat { get; init; }

    /// <summary>
    /// The SIRET (Système d'Identification du Répertoire des Entreprises et de leurs Etablissements)
    /// number is a 14-digit code issued by the French INSEE. For example, <c>39922799000021</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fr_siret")]
    public string? FrSiret { get; init; }

    /// <summary>
    /// The French government uses the NAF (Nomenclature des Activités Françaises) to display and
    /// track economic statistical data. This is also called the APE (Activite Principale de l’Entreprise) code.
    /// For example, <c>6910Z</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fr_naf")]
    public string? FrNaf { get; init; }

    /// <summary>
    /// The NIF (Numero de Identificacion Fiscal) number is a nine-character tax identifier used in Spain.
    /// If it is present, it has been validated. For example, <c>73628495A</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("es_nif")]
    public string? EsNif { get; init; }

    /// <summary>
    /// The QII (Qualified Invoice Issuer) number is a 14-character tax identifier used in Japan.
    /// For example, <c>T1234567890123</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jp_qii")]
    public string? JpQii { get; init; }
}
