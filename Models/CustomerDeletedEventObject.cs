using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// An object that contains the customer associated with the event.
/// </summary>
public record CustomerDeletedEventObject
{
    /// <summary>
    /// Represents a Square customer profile in the Customer Directory of a Square seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    /// <summary>
    /// Information about the change that triggered the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event_context")]
    public CustomerDeletedEventEventContext? EventContext { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
