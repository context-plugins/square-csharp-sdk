using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a contact of a <see href="entity:Vendor">Vendor</see>.
/// </summary>
public record VendorContact
{
    /// <summary>
    /// A unique Square-generated ID for the <see href="entity:VendorContact">VendorContact</see>.
    /// This field is required when attempting to update a <see href="entity:VendorContact">VendorContact</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(100)]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the <see href="entity:VendorContact">VendorContact</see>.
    /// This field is required when attempting to create a <see href="entity:Vendor">Vendor</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The email address of the <see href="entity:VendorContact">VendorContact</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [MaxLength(255)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The phone number of the <see href="entity:VendorContact">VendorContact</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    [MaxLength(255)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The state of the <see href="entity:VendorContact">VendorContact</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("removed")]
    public bool? Removed { get; init; }

    /// <summary>
    /// The ordinal of the <see href="entity:VendorContact">VendorContact</see>.
    /// </summary>
    [JsonPropertyName("ordinal")]
    public required int Ordinal { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
