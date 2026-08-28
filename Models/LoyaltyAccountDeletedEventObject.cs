using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

public record LoyaltyAccountDeletedEventObject
{
    /// <summary>
    /// Describes a loyalty account in a <see href="entity:LoyaltyProgram">loyalty program</see>. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-accounts">Create and Retrieve Loyalty Accounts</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_account")]
    public LoyaltyAccount? LoyaltyAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
