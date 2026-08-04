using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Loyalty-CalculateLoyaltyPoints">CalculateLoyaltyPoints</see> response.
/// </summary>
public record CalculateLoyaltyPointsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The number of points that the buyer can earn from the base loyalty program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points")]
    public int? Points { get; init; }

    /// <summary>
    /// The number of points that the buyer can earn from a loyalty promotion. To be eligible
    /// to earn promotion points, the purchase must first qualify for program points. When <c>order_id</c>
    /// is not provided in the request, this value is always 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promotion_points")]
    public int? PromotionPoints { get; init; }
}
