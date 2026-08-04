using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the values for the <c>archived_state</c> query expression
/// used in <see href="api-endpoint:Catalog-SearchCatalogItems">SearchCatalogItems</see>
/// to return the archived, not archived or either type of catalog items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ArchivedState>))]
public sealed record ArchivedState : StringEnum<ArchivedState>
{
    private ArchivedState(string value) : base(value)
    {
    }

    /// <summary>
    /// Requested items are not archived with the <c>is_archived</c> attribute set to <c>false</c>.
    /// </summary>
    public static readonly ArchivedState ArchivedStateNotArchived = new("ARCHIVED_STATE_NOT_ARCHIVED");

    /// <summary>
    /// Requested items are archived with the <c>is_archived</c> attribute set to <c>true</c>.
    /// </summary>
    public static readonly ArchivedState ArchivedStateArchived = new("ARCHIVED_STATE_ARCHIVED");

    /// <summary>
    /// Requested items can be archived or not archived.
    /// </summary>
    public static readonly ArchivedState ArchivedStateAll = new("ARCHIVED_STATE_ALL");

    public static ArchivedState FromValue(string value) => FromValueCore(value);
}
