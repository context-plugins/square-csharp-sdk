using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Details about the application that took the payment.
/// </summary>
public record ApplicationDetails
{
    /// <summary>
    /// A list of products to return to external callers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_product")]
    public ApplicationDetailsExternalSquareProduct? SquareProduct { get; init; }

    /// <summary>
    /// The Square ID assigned to the application used to take the payment.
    /// Application developers can use this information to identify payments that
    /// their application processed.
    /// For example, if a developer uses a custom application to process payments,
    /// this field contains the application ID from the Developer Dashboard.
    /// If a seller uses a <see href="https://developer.squareup.com/docs/app-marketplace">Square App Marketplace</see>
    /// application to process payments, the field contains the corresponding application ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; init; }
}
