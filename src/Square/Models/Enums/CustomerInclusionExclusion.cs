using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates whether customers should be included in, or excluded from,
/// the result set when they match the filtering criteria.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CustomerInclusionExclusion>))]
public sealed record CustomerInclusionExclusion : OpenStringEnum<CustomerInclusionExclusion>
{
    private CustomerInclusionExclusion(string value) : base(value)
    {
    }

    /// <summary>
    /// Customers should be included in the result set when they match the
    /// filtering criteria.
    /// </summary>
    public static readonly CustomerInclusionExclusion Include = new("INCLUDE");

    /// <summary>
    /// Customers should be excluded from the result set when they match
    /// the filtering criteria.
    /// </summary>
    public static readonly CustomerInclusionExclusion Exclude = new("EXCLUDE");

    public TResult Match<TResult>(Func<TResult> onInclude, Func<TResult> onExclude, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Include => onInclude(),
            _ when this == Exclude => onExclude(),
            _ => otherwise(Value)
        };

    public void Match(Action onInclude, Action onExclude, Action<string> otherwise)
    {
        if (this == Include) onInclude();
        else if (this == Exclude) onExclude();
        else otherwise(Value);
    }
}
