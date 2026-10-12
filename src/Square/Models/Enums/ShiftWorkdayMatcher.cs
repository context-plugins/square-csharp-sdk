using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the logic used to apply a workday filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftWorkdayMatcher>))]
public sealed record ShiftWorkdayMatcher : OpenStringEnum<ShiftWorkdayMatcher>
{
    private ShiftWorkdayMatcher(string value) : base(value)
    {
    }

    /// <summary>
    /// All shifts that start on or after the specified workday
    /// </summary>
    public static readonly ShiftWorkdayMatcher StartAt = new("START_AT");

    /// <summary>
    /// All shifts that end on or before the specified workday
    /// </summary>
    public static readonly ShiftWorkdayMatcher EndAt = new("END_AT");

    /// <summary>
    /// All shifts that start between the start and end workdays (inclusive)
    /// </summary>
    public static readonly ShiftWorkdayMatcher Intersection = new("INTERSECTION");

    public TResult Match<TResult>(Func<TResult> onStartAt,
        Func<TResult> onEndAt,
        Func<TResult> onIntersection,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartAt => onStartAt(),
            _ when this == EndAt => onEndAt(),
            _ when this == Intersection => onIntersection(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartAt, Action onEndAt, Action onIntersection, Action<string> otherwise)
    {
        if (this == StartAt) onStartAt();
        else if (this == EndAt) onEndAt();
        else if (this == Intersection) onIntersection();
        else otherwise(Value);
    }
}
