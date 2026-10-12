using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the values for the <c>archived_state</c> query expression
/// used in <see href="api-endpoint:Catalog-SearchCatalogItems">SearchCatalogItems</see>
/// to return the archived, not archived or either type of catalog items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ArchivedState>))]
public sealed record ArchivedState : OpenStringEnum<ArchivedState>
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

    public TResult Match<TResult>(Func<TResult> onArchivedStateNotArchived,
        Func<TResult> onArchivedStateArchived,
        Func<TResult> onArchivedStateAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ArchivedStateNotArchived => onArchivedStateNotArchived(),
            _ when this == ArchivedStateArchived => onArchivedStateArchived(),
            _ when this == ArchivedStateAll => onArchivedStateAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onArchivedStateNotArchived,
        Action onArchivedStateArchived,
        Action onArchivedStateAll,
        Action<string> otherwise)
    {
        if (this == ArchivedStateNotArchived) onArchivedStateNotArchived();
        else if (this == ArchivedStateArchived) onArchivedStateArchived();
        else if (this == ArchivedStateAll) onArchivedStateAll();
        else otherwise(Value);
    }
}
