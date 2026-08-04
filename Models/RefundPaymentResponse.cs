using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Defines the response returned by
/// <see href="api-endpoint:Refunds-RefundPayment">RefundPayment</see>.
/// <para>
/// If there are errors processing the request, the <c>refund</c> field might not be
/// present, or it might be present with a status of <c>FAILED</c>.
/// </para>
/// </summary>
public record RefundPaymentResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a refund of a payment made using Square. Contains information about
    /// the original payment and the amount of money refunded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public PaymentRefund? Refund { get; init; }
}
