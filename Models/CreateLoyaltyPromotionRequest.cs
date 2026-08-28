using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Represents a <see href="api-endpoint:Loyalty-CreateLoyaltyPromotion">CreateLoyaltyPromotion</see> request.
/// </summary>
public record CreateLoyaltyPromotionRequest
{
    /// <summary>
    /// Represents a promotion for a <see href="entity:LoyaltyProgram">loyalty program</see>. Loyalty promotions enable buyers
    /// to earn extra points on top of those earned from the base program.
    /// <para>
    /// A loyalty program can have a maximum of 10 loyalty promotions with an <c>ACTIVE</c> or <c>SCHEDULED</c> status.
    /// </para>
    /// </summary>
    [JsonPropertyName("loyalty_promotion")]
    public required LoyaltyPromotion LoyaltyPromotion { get; init; }

    /// <summary>
    /// A unique identifier for this request, which is used to ensure idempotency. For more information,
    /// see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency</see>.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
