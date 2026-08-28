using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in a request to the
/// <c>UpdateCustomer</c> endpoint.
/// </summary>
public record UpdateCustomerRequest
{
    /// <summary>
    /// The given name (that is, the first name) associated with the customer profile.
    /// <para>
    /// The maximum length for this value is 300 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The family name (that is, the last name) associated with the customer profile.
    /// <para>
    /// The maximum length for this value is 300 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// A business name associated with the customer profile.
    /// <para>
    /// The maximum length for this value is 500 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// A nickname for the customer profile.
    /// <para>
    /// The maximum length for this value is 100 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nickname")]
    public string? Nickname { get; init; }

    /// <summary>
    /// The email address associated with the customer profile.
    /// <para>
    /// The maximum length for this value is 254 characters.
    /// </para>
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
    /// The phone number associated with the customer profile. The phone number must be valid and can contain
    /// 9–16 digits, with an optional <c>+</c> prefix and country code. For more information, see
    /// <see href="https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#phone-number">Customer phone numbers</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// An optional second ID used to associate the customer profile with an
    /// entity in another system.
    /// <para>
    /// The maximum length for this value is 100 characters.
    /// </para>
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
    /// The birthday associated with the customer profile, in <c>YYYY-MM-DD</c> or <c>MM-DD</c> format. For example,
    /// specify <c>1998-09-21</c> for September 21, 1998, or <c>09-21</c> for September 21. Birthdays are returned in <c>YYYY-MM-DD</c>
    /// format, where <c>YYYY</c> is the specified birth year or <c>0000</c> if a birth year is not specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birthday")]
    public string? Birthday { get; init; }

    /// <summary>
    /// The current version of the customer profile.
    /// <para>
    /// As a best practice, you should include this field to enable <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/optimistic-concurrency">optimistic concurrency</see> control. For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#update-a-customer-profile">Update a customer profile</see>.
    /// </para>
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
