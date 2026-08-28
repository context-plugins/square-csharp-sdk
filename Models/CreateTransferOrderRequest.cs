using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;

namespace Square.Models;

/// <summary>
/// Request to create a new transfer order.
/// </summary>
public record CreateTransferOrderRequest
{
    /// <summary>
    /// A unique string that identifies this CreateTransferOrder request. Keys can be
    /// any valid string but must be unique for every CreateTransferOrder request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Data for creating a new transfer order to move <see href="entity:CatalogItemVariation">CatalogItemVariation</see>s
    /// between <see href="entity:Location">Location</see>s. Used with the <see href="api-endpoint:TransferOrders-CreateTransferOrder">CreateTransferOrder</see>
    /// endpoint.
    /// </summary>
    [JsonPropertyName("transfer_order")]
    public required CreateTransferOrderData TransferOrder { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
