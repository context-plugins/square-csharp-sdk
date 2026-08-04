using System.Text.Json.Serialization;

namespace Square.Models;

public record DeviceCheckoutOptions
{
    /// <summary>
    /// The unique ID of the device intended for this <c>TerminalCheckout</c>.
    /// A list of <c>DeviceCode</c> objects can be retrieved from the /v2/devices/codes endpoint.
    /// Match a <c>DeviceCode.device_id</c> value with <c>device_id</c> to get the associated device code.
    /// </summary>
    [JsonPropertyName("device_id")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// Instructs the device to skip the receipt screen. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_receipt_screen")]
    public bool? SkipReceiptScreen { get; init; }

    /// <summary>
    /// Indicates that signature collection is desired during checkout. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collect_signature")]
    public bool? CollectSignature { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_settings")]
    public TipSettings? TipSettings { get; init; }

    /// <summary>
    /// Show the itemization screen prior to taking a payment. This field is only meaningful when the
    /// checkout includes an order ID. Defaults to true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_itemized_cart")]
    public bool? ShowItemizedCart { get; init; }

    /// <summary>
    /// Controls whether the mobile client applies Auto Card Surcharge (ACS) during checkout.
    /// If true, ACS is applied based on Dashboard configuration.
    /// If false, ACS is not applied regardless of that configuration.
    /// For more information, see <see href="https://developer.squareup.com/docs/terminal-api/additional-payment-checkout-features#add-a-card-surcharge">Add a Card Surcharge</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_auto_card_surcharge")]
    public bool? AllowAutoCardSurcharge { get; init; }
}
