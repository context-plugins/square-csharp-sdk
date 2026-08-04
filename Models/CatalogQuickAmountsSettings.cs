using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// A parent Catalog Object model represents a set of Quick Amounts and the settings control the amounts.
/// </summary>
public record CatalogQuickAmountsSettings
{
    /// <summary>
    /// Determines a seller's option on Quick Amounts feature.
    /// </summary>
    [JsonPropertyName("option")]
    public required CatalogQuickAmountsSettingsOption Option { get; init; }

    /// <summary>
    /// Represents location's eligibility for auto amounts
    /// The boolean should be consistent with whether there are AUTO amounts in the <c>amounts</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligible_for_auto_amounts")]
    public bool? EligibleForAutoAmounts { get; init; }

    /// <summary>
    /// Represents a set of Quick Amounts at this location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amounts")]
    public IReadOnlyList<CatalogQuickAmount?>? Amounts { get; init; }
}
