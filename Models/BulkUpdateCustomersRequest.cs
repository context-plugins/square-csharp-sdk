using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="api-endpoint:Customers-BulkUpdateCustomers">BulkUpdateCustomers</see> endpoint.
/// </summary>
public record BulkUpdateCustomersRequest
{
    /// <summary>
    /// A map of 1 to 100 individual update requests, represented by <c>customer ID: { customer data }</c>
    /// key-value pairs.
    /// <para>
    /// Each key is the ID of the <see href="entity:Customer">customer profile</see> to update. To update a customer profile
    /// that was created by merging existing profiles, provide the ID of the newly created profile.
    /// </para>
    /// <para>
    /// Each value contains the updated customer data. Only new or changed fields are required. To add or
    /// update a field, specify the new value. To remove a field, specify <c>null</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("customers")]
    public required IReadOnlyDictionary<string, BulkUpdateCustomerData> Customers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
