using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

public record Channel
{
    /// <summary>
    /// The channel's unique ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique ID of the merchant this channel belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The name of the channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The version number which is incremented each time an update is made to the channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public Reference? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public ChannelStatus? Status { get; init; }

    /// <summary>
    /// The timestamp for when the channel was created, in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Working with Dates</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The timestamp for when the channel was last updated, in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Working with Dates</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
