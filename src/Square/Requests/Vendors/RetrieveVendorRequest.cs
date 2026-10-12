namespace Square.Requests.Vendors;

/// <summary>
/// The inputs of the RetrieveVendor operation.
/// </summary>
public sealed record RetrieveVendorRequest
{
    /// <summary>
    /// ID of the <see href="entity:Vendor">Vendor</see> to retrieve.
    /// </summary>
    public required string VendorId { get; init; }
}
