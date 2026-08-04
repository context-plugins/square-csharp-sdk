using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="api-endpoint:WebhookSubscriptions-UpdateWebhookSubscriptionSignatureKey">UpdateWebhookSubscriptionSignatureKey</see> endpoint.
/// <para>
/// Note: If there are errors processing the request, the <see href="entity:WebhookSubscription">Subscription</see> is not
/// present.
/// </para>
/// </summary>
public record UpdateWebhookSubscriptionSignatureKeyResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The new Square-generated signature key used to validate the origin of the webhook event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature_key")]
    public string? SignatureKey { get; init; }
}
