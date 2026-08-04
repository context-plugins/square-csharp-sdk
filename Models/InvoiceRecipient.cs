using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a snapshot of customer data. This object stores customer data that is displayed on the invoice
/// and that Square uses to deliver the invoice.
/// <para>
/// When you provide a customer ID for a draft invoice, Square retrieves the associated customer profile and populates
/// the remaining <c>InvoiceRecipient</c> fields. You cannot update these fields after the invoice is published.
/// Square updates the customer ID in response to a merge operation, but does not update other fields.
/// </para>
/// </summary>
public record InvoiceRecipient
{
    /// <summary>
    /// The ID of the customer. This is the customer profile ID that
    /// you provide when creating a draft invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The recipient's given (that is, first) name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The recipient's family (that is, last) name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// The recipient's email address.
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
    /// The recipient's phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The name of the recipient's company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// Represents the tax IDs for an invoice recipient. The country of the seller account determines
    /// whether the corresponding <c>tax_ids</c> field is available for the customer. For more information,
    /// see <see href="https://developer.squareup.com/docs/invoices-api/overview#recipient-tax-ids">Invoice recipient tax IDs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public InvoiceRecipientTaxIds? TaxIds { get; init; }
}
