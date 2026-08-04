using System.Text.Json.Serialization;

namespace Square.Models;

/// <summary>
/// The parameters of a <c>Shift</c> search query, which includes filter and sort options.
/// <para>
/// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
/// </para>
/// </summary>
public record ShiftQuery
{
    /// <summary>
    /// Defines a filter used in a search for <c>Shift</c> records. <c>AND</c> logic is
    /// used by Square's servers to apply each filter property specified.
    /// <para>
    /// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public ShiftFilter? Filter { get; init; }

    /// <summary>
    /// Sets the sort order of search results.
    /// <para>
    /// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public ShiftSort? Sort { get; init; }
}
