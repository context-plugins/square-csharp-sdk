using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the <c>Shift</c> fields to sort on.
/// <para>
/// Deprecated at Square API version 2025-05-21. See the <see href="https://developer.squareup.com/docs/labor-api/what-it-does#migration-notes">migration notes</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftSortField>))]
public sealed record ShiftSortField : OpenStringEnum<ShiftSortField>
{
    private ShiftSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The start date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField StartAt = new("START_AT");

    /// <summary>
    /// The end date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField EndAt = new("END_AT");

    /// <summary>
    /// The date/time that a <c>Shift</c> is created
    /// </summary>
    public static readonly ShiftSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The most recent date/time that a <c>Shift</c> is updated
    /// </summary>
    public static readonly ShiftSortField UpdatedAt = new("UPDATED_AT");

    public TResult Match<TResult>(Func<TResult> onStartAt,
        Func<TResult> onEndAt,
        Func<TResult> onCreatedAt,
        Func<TResult> onUpdatedAt,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartAt => onStartAt(),
            _ when this == EndAt => onEndAt(),
            _ when this == CreatedAt => onCreatedAt(),
            _ when this == UpdatedAt => onUpdatedAt(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartAt,
        Action onEndAt,
        Action onCreatedAt,
        Action onUpdatedAt,
        Action<string> otherwise)
    {
        if (this == StartAt) onStartAt();
        else if (this == EndAt) onEndAt();
        else if (this == CreatedAt) onCreatedAt();
        else if (this == UpdatedAt) onUpdatedAt();
        else otherwise(Value);
    }
}
