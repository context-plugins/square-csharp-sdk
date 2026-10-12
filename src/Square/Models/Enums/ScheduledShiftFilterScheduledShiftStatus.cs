using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines valid values for the <c>scheduled_shift_statuses</c> filter in a
/// <see href="api-endpoint:Labor-SearchScheduledShifts">SearchScheduledShifts</see> request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScheduledShiftFilterScheduledShiftStatus>))]
public sealed record ScheduledShiftFilterScheduledShiftStatus : OpenStringEnum<ScheduledShiftFilterScheduledShiftStatus>
{
    private ScheduledShiftFilterScheduledShiftStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The scheduled shift has never been published or its draft details were
    /// updated after it was published. This means that the shift has no <c>published_shift_details</c>
    /// field or that <c>draft_shift_details</c> has different settings than <c>published_shift_details</c>.
    /// </summary>
    public static readonly ScheduledShiftFilterScheduledShiftStatus Draft = new("DRAFT");

    /// <summary>
    /// The scheduled shift was published. This means that the shift has a
    /// <c>published_shift_details</c> field.
    /// </summary>
    public static readonly ScheduledShiftFilterScheduledShiftStatus Published = new("PUBLISHED");

    public TResult Match<TResult>(Func<TResult> onDraft, Func<TResult> onPublished, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Draft => onDraft(),
            _ when this == Published => onPublished(),
            _ => otherwise(Value)
        };

    public void Match(Action onDraft, Action onPublished, Action<string> otherwise)
    {
        if (this == Draft) onDraft();
        else if (this == Published) onPublished();
        else otherwise(Value);
    }
}
