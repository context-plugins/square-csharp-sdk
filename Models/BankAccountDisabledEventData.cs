using System.Text.Json.Serialization;

namespace Square.Models;

public record BankAccountDisabledEventData
{
    /// <summary>
    /// Name of the affected object’s type, <c>"bank_account"</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// ID of the affected bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public BankAccountDisabledEventObject? Object { get; init; }
}
