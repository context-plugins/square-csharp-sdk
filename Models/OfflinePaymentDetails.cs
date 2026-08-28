using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Details specific to offline payments.
/// </summary>
public record OfflinePaymentDetails
{
    /// <summary>
    /// The client-side timestamp of when the offline payment was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_created_at")]
    [MaxLength(32)]
    public string? ClientCreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
