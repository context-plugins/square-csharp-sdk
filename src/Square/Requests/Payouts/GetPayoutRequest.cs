namespace Square.Requests.Payouts;

/// <summary>
/// The inputs of the GetPayout operation.
/// </summary>
public sealed record GetPayoutRequest
{
    /// <summary>
    /// The ID of the payout to retrieve the information for.
    /// </summary>
    public required string PayoutId { get; init; }
}
