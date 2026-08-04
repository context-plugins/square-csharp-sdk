using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// Describes a request to complete (capture) a payment using
/// <see href="api-endpoint:Payments-CompletePayment">CompletePayment</see>.
/// <para>
/// By default, payments are set to <c>autocomplete</c> immediately after they are created.
/// To complete payments manually, set <c>autocomplete</c> to <c>false</c>.
/// </para>
/// </summary>
public record CompletePaymentRequest
{
    /// <summary>
    /// Used for optimistic concurrency. This opaque token identifies the current <c>Payment</c>
    /// version that the caller expects. If the server has a different version of the Payment,
    /// the update fails and a response with a VERSION_MISMATCH error is returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version_token")]
    public string? VersionToken { get; init; }
}
