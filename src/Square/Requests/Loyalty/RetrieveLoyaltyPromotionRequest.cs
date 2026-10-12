namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyPromotion operation.
/// </summary>
public sealed record RetrieveLoyaltyPromotionRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyPromotion">loyalty promotion</see> to retrieve.
    /// </summary>
    public required string PromotionId { get; init; }

    /// <summary>
    /// The ID of the base <see href="entity:LoyaltyProgram">loyalty program</see>. To get the program ID,
    /// call <see href="api-endpoint:Loyalty-RetrieveLoyaltyProgram">RetrieveLoyaltyProgram</see> using the <c>main</c> keyword.
    /// </summary>
    public required string ProgramId { get; init; }
}
