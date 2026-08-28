using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// An object that contains the loyalty program associated with a <c>loyalty.program.updated</c> event.
/// </summary>
public record LoyaltyProgramUpdatedEventObject
{
    /// <summary>
    /// Represents a Square loyalty program. Loyalty programs define how buyers can earn points and redeem points for rewards.
    /// Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_program")]
    public LoyaltyProgram? LoyaltyProgram { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
