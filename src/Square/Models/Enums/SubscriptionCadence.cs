using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines the billing cadence of a <see href="entity:Subscription">Subscription</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionCadence>))]
public sealed record SubscriptionCadence : OpenStringEnum<SubscriptionCadence>
{
    private SubscriptionCadence(string value) : base(value)
    {
    }

    /// <summary>
    /// Once per day
    /// </summary>
    public static readonly SubscriptionCadence Daily = new("DAILY");

    /// <summary>
    /// Once per week
    /// </summary>
    public static readonly SubscriptionCadence Weekly = new("WEEKLY");

    /// <summary>
    /// Every two weeks
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoWeeks = new("EVERY_TWO_WEEKS");

    /// <summary>
    /// Once every 30 days
    /// </summary>
    public static readonly SubscriptionCadence ThirtyDays = new("THIRTY_DAYS");

    /// <summary>
    /// Once every 60 days
    /// </summary>
    public static readonly SubscriptionCadence SixtyDays = new("SIXTY_DAYS");

    /// <summary>
    /// Once every 90 days
    /// </summary>
    public static readonly SubscriptionCadence NinetyDays = new("NINETY_DAYS");

    /// <summary>
    /// Once per month
    /// </summary>
    public static readonly SubscriptionCadence Monthly = new("MONTHLY");

    /// <summary>
    /// Once every two months
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoMonths = new("EVERY_TWO_MONTHS");

    /// <summary>
    /// Once every three months
    /// </summary>
    public static readonly SubscriptionCadence Quarterly = new("QUARTERLY");

    /// <summary>
    /// Once every four months
    /// </summary>
    public static readonly SubscriptionCadence EveryFourMonths = new("EVERY_FOUR_MONTHS");

    /// <summary>
    /// Once every six months
    /// </summary>
    public static readonly SubscriptionCadence EverySixMonths = new("EVERY_SIX_MONTHS");

    /// <summary>
    /// Once per year
    /// </summary>
    public static readonly SubscriptionCadence Annual = new("ANNUAL");

    /// <summary>
    /// Once every two years
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoYears = new("EVERY_TWO_YEARS");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onEveryTwoWeeks,
        Func<TResult> onThirtyDays,
        Func<TResult> onSixtyDays,
        Func<TResult> onNinetyDays,
        Func<TResult> onMonthly,
        Func<TResult> onEveryTwoMonths,
        Func<TResult> onQuarterly,
        Func<TResult> onEveryFourMonths,
        Func<TResult> onEverySixMonths,
        Func<TResult> onAnnual,
        Func<TResult> onEveryTwoYears,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == EveryTwoWeeks => onEveryTwoWeeks(),
            _ when this == ThirtyDays => onThirtyDays(),
            _ when this == SixtyDays => onSixtyDays(),
            _ when this == NinetyDays => onNinetyDays(),
            _ when this == Monthly => onMonthly(),
            _ when this == EveryTwoMonths => onEveryTwoMonths(),
            _ when this == Quarterly => onQuarterly(),
            _ when this == EveryFourMonths => onEveryFourMonths(),
            _ when this == EverySixMonths => onEverySixMonths(),
            _ when this == Annual => onAnnual(),
            _ when this == EveryTwoYears => onEveryTwoYears(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily,
        Action onWeekly,
        Action onEveryTwoWeeks,
        Action onThirtyDays,
        Action onSixtyDays,
        Action onNinetyDays,
        Action onMonthly,
        Action onEveryTwoMonths,
        Action onQuarterly,
        Action onEveryFourMonths,
        Action onEverySixMonths,
        Action onAnnual,
        Action onEveryTwoYears,
        Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == EveryTwoWeeks) onEveryTwoWeeks();
        else if (this == ThirtyDays) onThirtyDays();
        else if (this == SixtyDays) onSixtyDays();
        else if (this == NinetyDays) onNinetyDays();
        else if (this == Monthly) onMonthly();
        else if (this == EveryTwoMonths) onEveryTwoMonths();
        else if (this == Quarterly) onQuarterly();
        else if (this == EveryFourMonths) onEveryFourMonths();
        else if (this == EverySixMonths) onEverySixMonths();
        else if (this == Annual) onAnnual();
        else if (this == EveryTwoYears) onEveryTwoYears();
        else otherwise(Value);
    }
}
