using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a bank account. For more information about
/// linking a bank account to a Square account, see
/// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
/// </summary>
public record BankAccount
{
    /// <summary>
    /// The unique, Square-issued identifier for the bank account.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(30, MinimumLength = 1)]
    public required string Id { get; init; }

    /// <summary>
    /// The last few digits of the account number.
    /// </summary>
    [JsonPropertyName("account_number_suffix")]
    [MinLength(1)]
    public required string AccountNumberSuffix { get; init; }

    /// <summary>
    /// Indicates the country associated with another entity, such as a business.
    /// Values are in <see href="http://www.iso.org/iso/home/standards/country_codes.htm">ISO 3166-1-alpha-2 format</see>.
    /// </summary>
    [JsonPropertyName("country")]
    public required Country Country { get; init; }

    /// <summary>
    /// Indicates the associated currency for an amount of money. Values correspond
    /// to <see href="https://wikipedia.org/wiki/ISO_4217">ISO 4217</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// Indicates the financial purpose of the bank account.
    /// </summary>
    [JsonPropertyName("account_type")]
    public required BankAccountType AccountType { get; init; }

    /// <summary>
    /// Name of the account holder. This name must match the name
    /// on the targeted bank account record.
    /// </summary>
    [JsonPropertyName("holder_name")]
    [MinLength(1)]
    public required string HolderName { get; init; }

    /// <summary>
    /// Primary identifier for the bank. For more information, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonPropertyName("primary_bank_identification_number")]
    [MaxLength(40)]
    public required string PrimaryBankIdentificationNumber { get; init; }

    /// <summary>
    /// Secondary identifier for the bank. For more information, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_bank_identification_number")]
    [MaxLength(40)]
    public string? SecondaryBankIdentificationNumber { get; init; }

    /// <summary>
    /// Reference identifier that will be displayed to UK bank account owners
    /// when collecting direct debit authorization. Only required for UK bank accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_mandate_reference_id")]
    public string? DebitMandateReferenceId { get; init; }

    /// <summary>
    /// Client-provided identifier for linking the banking account to an entity
    /// in a third-party system (for example, a bank account number or a user identifier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The location to which the bank account belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Indicates the current verification status of a <c>BankAccount</c> object.
    /// </summary>
    [JsonPropertyName("status")]
    public required BankAccountStatus Status { get; init; }

    /// <summary>
    /// Indicates whether it is possible for Square to send money to this bank account.
    /// </summary>
    [JsonPropertyName("creditable")]
    public required bool Creditable { get; init; }

    /// <summary>
    /// Indicates whether it is possible for Square to take money from this
    /// bank account.
    /// </summary>
    [JsonPropertyName("debitable")]
    public required bool Debitable { get; init; }

    /// <summary>
    /// A Square-assigned, unique identifier for the bank account based on the
    /// account information. The account fingerprint can be used to compare account
    /// entries and determine if the they represent the same real-world bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; init; }

    /// <summary>
    /// The current version of the <c>BankAccount</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// Read only. Name of actual financial institution.
    /// For example "Bank of America".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_name")]
    [MaxLength(100)]
    public string? BankName { get; init; }

    /// <summary>
    /// The ID of the customer who owns the bank account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
