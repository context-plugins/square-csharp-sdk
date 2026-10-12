namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyAccount operation.
/// </summary>
public sealed record RetrieveLoyaltyAccountRequest
{
    /// <summary>
    /// The ID of the <see href="entity:LoyaltyAccount">loyalty account</see> to retrieve.
    /// </summary>
    public required string AccountId { get; init; }
}
