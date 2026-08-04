using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

public record PaymentLinkRelatedResources
{
    /// <summary>
    /// The order associated with the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orders")]
    public IReadOnlyList<Order?>? Orders { get; init; }

    /// <summary>
    /// The subscription plan associated with the payment link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plans")]
    public IReadOnlyList<CatalogObject?>? SubscriptionPlans { get; init; }
}
