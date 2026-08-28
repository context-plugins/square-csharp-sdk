using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents the tax ID associated with a <see href="entity:Customer">customer profile</see>. The corresponding <c>tax_ids</c> field is available only for customers of sellers in EU countries or the United Kingdom.
/// For more information, see <see href="https://developer.squareup.com/docs/customers-api/what-it-does#customer-tax-ids">Customer tax IDs</see>.
/// </summary>
public record CustomerTaxIds
{
    /// <summary>
    /// The EU VAT identification number for the customer. For example, <c>IE3426675K</c>. The ID can contain alphanumeric characters only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eu_vat")]
    [MaxLength(20)]
    public string? EuVat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
