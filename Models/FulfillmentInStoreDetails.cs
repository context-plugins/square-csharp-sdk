using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Contains the details necessary to fulfill an in-store order.
/// </summary>
public record FulfillmentInStoreDetails
{
    /// <summary>
    /// A note to provide additional instructions about the in-store fulfillment
    /// displayed in the Square Point of Sale application and set by the API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(550)]
    public string? Note { get; init; }

    /// <summary>
    /// Information about the fulfillment recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public FulfillmentRecipient? Recipient { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placed_at")]
    public string? PlacedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was completed. This field is automatically set when the
    /// fulfillment <c>state</c> changes to <c>COMPLETED</c>. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_at")]
    public string? CompletedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicates when the seller started processing the fulfillment.
    /// This field is automatically set when the fulfillment <c>state</c> changes to <c>RESERVED</c>.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("in_progress_at")]
    public string? InProgressAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was moved to the <c>PREPARED</c> state, which indicates that the
    /// fulfillment is ready. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepared_at")]
    public string? PreparedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was canceled. This field is automatically set when the
    /// fulfillment <c>state</c> changes to <c>CANCELED</c>. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
