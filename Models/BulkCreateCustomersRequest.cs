using System.Collections.Generic;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Defines the body parameters that can be included in requests to the
/// <see href="api-endpoint:Customers-BulkCreateCustomers">BulkCreateCustomers</see> endpoint.
/// </summary>
public record BulkCreateCustomersRequest
{
    /// <summary>
    /// A map of 1 to 100 individual create requests, represented by <c>idempotency key: { customer data }</c>
    /// key-value pairs.
    /// <para>
    /// Each key is an <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">idempotency key</see>
    /// that uniquely identifies the create request. Each value contains the customer data used to create the
    /// customer profile.
    /// </para>
    /// </summary>
    [JsonPropertyName("customers")]
    public required IReadOnlyDictionary<string, BulkCreateCustomerData> Customers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
