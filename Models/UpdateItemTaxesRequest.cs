using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record UpdateItemTaxesRequest
{
    /// <summary>
    /// IDs for the CatalogItems associated with the CatalogTax objects being updated.
    /// No more than 1,000 IDs may be provided.
    /// </summary>
    [JsonPropertyName("item_ids")]
    public required IReadOnlyList<string> ItemIds { get; init; }

    /// <summary>
    /// IDs of the CatalogTax objects to enable.
    /// At least one of <c>taxes_to_enable</c> or <c>taxes_to_disable</c> must be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes_to_enable")]
    public IReadOnlyList<string?>? TaxesToEnable { get; init; }

    /// <summary>
    /// IDs of the CatalogTax objects to disable.
    /// At least one of <c>taxes_to_enable</c> or <c>taxes_to_disable</c> must be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes_to_disable")]
    public IReadOnlyList<string?>? TaxesToDisable { get; init; }
}
