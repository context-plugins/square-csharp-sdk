using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A filter based on the order <c>customer_id</c> and any tender <c>customer_id</c>
/// associated with the order. It does not filter based on the
/// <see href="entity:FulfillmentRecipient">FulfillmentRecipient</see> <c>customer_id</c>.
/// </summary>
public record SearchOrdersCustomerFilter
{
    /// <summary>
    /// A list of customer IDs to filter by.
    /// <para>
    /// Max: 10 customer ids.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ids")]
    public IReadOnlyList<string?>? CustomerIds { get; init; }
}
