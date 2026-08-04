using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The origination details of the subscription.
/// </summary>
public record SubscriptionSource
{
    /// <summary>
    /// The name used to identify the place (physical or digital) that
    /// a subscription originates. If unset, the name defaults to the name
    /// of the application that created the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }
}
