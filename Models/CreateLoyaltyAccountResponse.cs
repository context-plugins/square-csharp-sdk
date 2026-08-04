using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A response that includes loyalty account created.
/// </summary>
public record CreateLoyaltyAccountResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Describes a loyalty account in a <see href="entity:LoyaltyProgram">loyalty program</see>. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/loyalty-accounts">Create and Retrieve Loyalty Accounts</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_account")]
    public LoyaltyAccount? LoyaltyAccount { get; init; }
}
