using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes buyer data to prepopulate in the payment form.
/// For more information,
/// see <see href="https://developer.squareup.com/docs/checkout-api/optional-checkout-configurations">Optional Checkout Configurations</see>.
/// </summary>
public record PrePopulatedData
{
    /// <summary>
    /// The buyer email to prepopulate in the payment form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_email")]
    [MaxLength(256)]
    public string? BuyerEmail { get; init; }

    /// <summary>
    /// The buyer phone number to prepopulate in the payment form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_phone_number")]
    [MaxLength(17)]
    public string? BuyerPhoneNumber { get; init; }

    /// <summary>
    /// Represents a postal address in a country.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-addresses">Working with Addresses</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_address")]
    public Address? BuyerAddress { get; init; }
}
