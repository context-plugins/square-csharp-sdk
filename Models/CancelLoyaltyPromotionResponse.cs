using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Loyalty-CancelLoyaltyPromotion">CancelLoyaltyPromotion</see> response.
/// Either <c>loyalty_promotion</c> or <c>errors</c> is present in the response.
/// </summary>
public record CancelLoyaltyPromotionResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a promotion for a <see href="entity:LoyaltyProgram">loyalty program</see>. Loyalty promotions enable buyers
    /// to earn extra points on top of those earned from the base program.
    /// <para>
    /// A loyalty program can have a maximum of 10 loyalty promotions with an <c>ACTIVE</c> or <c>SCHEDULED</c> status.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_promotion")]
    public LoyaltyPromotion? LoyaltyPromotion { get; init; }
}
