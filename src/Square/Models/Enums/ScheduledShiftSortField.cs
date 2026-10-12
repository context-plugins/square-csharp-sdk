using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines valid values for the <c>field</c> sort setting in a
/// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftSortField>))]
public sealed record ScheduledShiftSortField : OpenStringEnum<ScheduledShiftSortField>
{
    private ScheduledShiftSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// Sort by the start time of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField StartAt = new("START_AT");

    /// <summary>
    /// Sort by the end time of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField EndAt = new("END_AT");

    /// <summary>
    /// Sort by the creation date of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// Sort by the last updated date of the shift.
    /// </summary>
    public static readonly ScheduledShiftSortField UpdatedAt = new("UPDATED_AT");

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
