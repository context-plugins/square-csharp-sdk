using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a supplier to a seller.
/// </summary>
public record Vendor
{
    /// <summary>
    /// A unique Square-generated ID for the <see href="entity:Vendor">Vendor</see>.
    /// This field is required when attempting to update a <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(100)]
    public string? Id { get; init; }

    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the
    /// <see href="entity:Vendor">Vendor</see> was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(34)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the
    /// <see href="entity:Vendor">Vendor</see> was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    [MaxLength(34)]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The name of the <see href="entity:Vendor">Vendor</see>.
    /// This field is required when attempting to create or update a <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(100)]
    public string? Name { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// The contacts of the <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contacts")]
    public IReadOnlyList<VendorContact>? Contacts { get; init; }

    /// <summary>
    /// The account number of the <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_number")]
    [MaxLength(100)]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// A note detailing information about the <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(4096)]
    public string? Note { get; init; }

    /// <summary>
    /// The version of the <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The status of the <see href="entity:Vendor">Vendor</see>,
    /// whether a <see href="entity:Vendor">Vendor</see> is active or inactive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public VendorStatus? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
