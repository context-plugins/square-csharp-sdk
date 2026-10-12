namespace Square.Requests.Loyalty;

/// <summary>
/// The inputs of the RetrieveLoyaltyProgram operation.
/// </summary>
public sealed record RetrieveLoyaltyProgramRequest
{
    /// <summary>
    /// The ID of the loyalty program or the keyword <c>main</c>. Either value can be used to retrieve the single loyalty program that belongs to the seller.
    /// </summary>
    public required string ProgramId { get; init; }
}
