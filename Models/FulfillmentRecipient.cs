using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Information about the fulfillment recipient.
/// </summary>
public record FulfillmentRecipient
{
    /// <summary>
    /// The ID of the customer associated with the fulfillment.
    /// <para>
    /// If <c>customer_id</c> is provided, the fulfillment recipient's <c>display_name</c>,
    /// <c>email_address</c>, and <c>phone_number</c> are automatically populated from the
    /// targeted customer profile. If these fields are set in the request, the request
    /// values override the information from the customer profile. If the
    /// targeted customer profile does not contain the necessary information and
    /// these fields are left unset, the request results in an error.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The display name of the fulfillment recipient. This field is required.
    /// <para>
    /// If provided, the display name overrides the corresponding customer profile value
    /// indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [MaxLength(255)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The email address of the fulfillment recipient.
    /// <para>
    /// If provided, the email address overrides the corresponding customer profile value
    /// indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [MaxLength(255)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The phone number of the fulfillment recipient. This field is required.
    /// <para>
    /// If provided, the phone number overrides the corresponding customer profile value
    /// indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    [MaxLength(18)]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address? Address { get; init; }
}
