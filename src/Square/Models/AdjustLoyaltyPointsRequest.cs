using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents an <see href="api-endpoint:Loyalty-AdjustLoyaltyPoints">AdjustLoyaltyPoints</see> request.
/// </summary>
public record AdjustLoyaltyPointsRequest
{
    /// <summary>
    /// A unique string that identifies this <c>AdjustLoyaltyPoints</c> request.
    /// Keys can be any valid string, but must be unique for every request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Provides metadata when the event <c>type</c> is <c>ADJUST_POINTS</c>.
    /// </summary>
    [JsonPropertyName("adjust_points")]
    public required LoyaltyEventAdjustPoints AdjustPoints { get; init; }

    /// <summary>
    /// Indicates whether to allow a negative adjustment to result in a negative balance. If <c>true</c>, a negative
    /// balance is allowed when subtracting points. If <c>false</c>, Square returns a <c>BAD_REQUEST</c> error when subtracting
    /// the specified number of points would result in a negative balance. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_negative_balance")]
    public bool? AllowNegativeBalance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
