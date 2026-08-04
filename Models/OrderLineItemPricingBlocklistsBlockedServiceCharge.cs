using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// A service charge to block from applying to a line item. The service charge
/// must be identified by either <c>service_charge_uid</c> or
/// <c>service_charge_catalog_object_id</c>, but not both.
/// </summary>
public record OrderLineItemPricingBlocklistsBlockedServiceCharge
{
    /// <summary>
    /// A unique ID of the <c>BlockedServiceCharge</c> within the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }

    /// <summary>
    /// The <c>uid</c> of the service charge that should be blocked. Use this field to
    /// block ad hoc service charges. For catalog service charges, use the
    /// <c>service_charge_catalog_object_id</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_charge_uid")]
    [MaxLength(60)]
    public string? ServiceChargeUid { get; init; }

    /// <summary>
    /// The <c>catalog_object_id</c> of the service charge that should be blocked.
    /// Use this field to block catalog service charges. For ad hoc service charges,
    /// use the <c>service_charge_uid</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("service_charge_catalog_object_id")]
    [MaxLength(192)]
    public string? ServiceChargeCatalogObjectId { get; init; }
}
