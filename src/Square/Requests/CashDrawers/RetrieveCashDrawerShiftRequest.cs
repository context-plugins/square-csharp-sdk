namespace Square.Requests.CashDrawers;

/// <summary>
/// The inputs of the RetrieveCashDrawerShift operation.
/// </summary>
public sealed record RetrieveCashDrawerShiftRequest
{
    /// <summary>
    /// The shift ID.
    /// </summary>
    public required string ShiftId { get; init; }

    /// <summary>
    /// The ID of the location to retrieve cash drawer shifts from.
    /// </summary>
    public required string LocationId { get; init; }
}
