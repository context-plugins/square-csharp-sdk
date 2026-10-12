using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Item level overrides for bool attributes
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierToggleOverrideType>))]
public sealed record CatalogModifierToggleOverrideType : OpenStringEnum<CatalogModifierToggleOverrideType>
{
    private CatalogModifierToggleOverrideType(string value) : base(value)
    {
    }

    /// <summary>
    /// False override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType No = new("NO");

    /// <summary>
    /// True override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType Yes = new("YES");

    /// <summary>
    /// No override
    /// </summary>
    public static readonly CatalogModifierToggleOverrideType NotSet = new("NOT_SET");

    public TResult Match<TResult>(Func<TResult> onNo,
        Func<TResult> onYes,
        Func<TResult> onNotSet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == No => onNo(),
            _ when this == Yes => onYes(),
            _ when this == NotSet => onNotSet(),
            _ => otherwise(Value)
        };

    public void Match(Action onNo, Action onYes, Action onNotSet, Action<string> otherwise)
    {
        if (this == No) onNo();
        else if (this == Yes) onYes();
        else if (this == NotSet) onNotSet();
        else otherwise(Value);
    }
}
