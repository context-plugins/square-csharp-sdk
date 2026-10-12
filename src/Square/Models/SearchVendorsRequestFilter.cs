using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Defines supported query expressions to search for vendors by.
/// </summary>
public record SearchVendorsRequestFilter
{
    /// <summary>
    /// The names of the <see href="entity:Vendor">Vendor</see> objects to retrieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public IReadOnlyList<string>? Name { get; init; }

    /// <summary>
    /// The statuses of the <see href="entity:Vendor">Vendor</see> objects to retrieve.
    /// See <see href="#type-vendorstatus">VendorStatus</see> for possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public IReadOnlyList<VendorStatus>? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
