using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a Square customer profile in the Customer Directory of a Square seller.
/// </summary>
public record Customer
{
    /// <summary>
    /// A unique Square-assigned ID for the customer profile.
    /// <para>
    /// If you need this ID for an API request, use the ID returned when you created the customer profile or call the <see href="api-endpoint:Customers-SearchCustomers">SearchCustomers</see>
    /// or <see href="api-endpoint:Customers-ListCustomers">ListCustomers</see> endpoint.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The timestamp when the customer profile was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the customer profile was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The given name (that is, the first name) associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The family name (that is, the last name) associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// A nickname for the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nickname")]
    public string? Nickname { get; init; }

    /// <summary>
    /// A business name associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// The email address associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// The phone number associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The birthday associated with the customer profile, in <c>YYYY-MM-DD</c> format. For example, <c>1998-09-21</c>
    /// represents September 21, 1998, and <c>0000-09-21</c> represents September 21 (without a birth year).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birthday")]
    public string? Birthday { get; init; }

    /// <summary>
    /// An optional second ID used to associate the customer profile with an
    /// entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// A custom note associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    public string? Note { get; init; }

    /// <summary>
    /// Represents communication preferences for the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preferences")]
    public CustomerPreferences? Preferences { get; init; }

    /// <summary>
    /// Indicates the method used to create the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creation_source")]
    public CustomerCreationSource? CreationSource { get; init; }

    /// <summary>
    /// The IDs of <see href="entity:CustomerGroup">customer groups</see> the customer belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_ids")]
    public IReadOnlyList<string?>? GroupIds { get; init; }

    /// <summary>
    /// The IDs of <see href="entity:CustomerSegment">customer segments</see> the customer belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment_ids")]
    public IReadOnlyList<string?>? SegmentIds { get; init; }

    /// <summary>
    /// The Square-assigned version number of the customer profile. The version number is incremented each time an update is committed to the customer profile, except for changes to customer segment membership.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    /// <summary>
    /// Represents the tax ID associated with a <see href="entity:Customer">customer profile</see>. The corresponding <c>tax_ids</c> field is available only for customers of sellers in EU countries or the United Kingdom.
    /// For more information, see <see href="https://developer.squareup.com/docs/customers-api/what-it-does#customer-tax-ids">Customer tax IDs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public CustomerTaxIds? TaxIds { get; init; }
}
