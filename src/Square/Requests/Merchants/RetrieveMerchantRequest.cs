namespace Square.Requests.Merchants;

/// <summary>
/// The inputs of the RetrieveMerchant operation.
/// </summary>
public sealed record RetrieveMerchantRequest
{
    /// <summary>
    /// The ID of the merchant to retrieve. If the string "me" is supplied as the ID,
    /// then retrieve the merchant that is currently accessible to this call.
    /// </summary>
    public required string MerchantId { get; init; }
}
