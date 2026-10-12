using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the <c>Timecard</c> fields to sort on.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TimecardSortField>))]
public sealed record TimecardSortField : OpenStringEnum<TimecardSortField>
{
    private TimecardSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The start date/time of a <c>Timecard</c>
    /// </summary>
    public static readonly TimecardSortField StartAt = new("START_AT");

    /// <summary>
    /// The end date/time of a <c>Timecard</c>
    /// </summary>
    public static readonly TimecardSortField EndAt = new("END_AT");

    /// <summary>
    /// The date/time that a <c>Timecard</c> is created
    /// </summary>
    public static readonly TimecardSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The most recent date/time that a <c>Timecard</c> is updated
    /// </summary>
    public static readonly TimecardSortField UpdatedAt = new("UPDATED_AT");

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
