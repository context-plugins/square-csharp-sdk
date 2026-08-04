using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents an error encountered during a request to the Connect API.
/// <para>
/// See <see href="https://developer.squareup.com/docs/build-basics/handling-errors">Handling errors</see> for more information.
/// </para>
/// </summary>
public record Error
{
    /// <summary>
    /// Indicates which high-level category of error has occurred during a
    /// request to the Connect API.
    /// </summary>
    [JsonPropertyName("category")]
    public required ErrorCategory Category { get; init; }

    /// <summary>
    /// Indicates the specific error that occurred during a request to a
    /// Square API.
    /// </summary>
    [JsonPropertyName("code")]
    public required ErrorCode Code { get; init; }

    /// <summary>
    /// A human-readable description of the error for debugging purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }

    /// <summary>
    /// The name of the field provided in the original request (if any) that
    /// the error pertains to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }
}
