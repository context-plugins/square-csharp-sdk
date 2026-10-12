using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines a seller's option on Quick Amounts feature.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogQuickAmountsSettingsOption>))]
public sealed record CatalogQuickAmountsSettingsOption : OpenStringEnum<CatalogQuickAmountsSettingsOption>
{
    private CatalogQuickAmountsSettingsOption(string value) : base(value)
    {
    }

    /// <summary>
    /// Option for seller to disable Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Disabled = new("DISABLED");

    /// <summary>
    /// Option for seller to choose manually created Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Manual = new("MANUAL");

    /// <summary>
    /// Option for seller to choose automatically created Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Auto = new("AUTO");

    public TResult Match<TResult>(Func<TResult> onDisabled,
        Func<TResult> onManual,
        Func<TResult> onAuto,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Disabled => onDisabled(),
            _ when this == Manual => onManual(),
            _ when this == Auto => onAuto(),
            _ => otherwise(Value)
        };

    public void Match(Action onDisabled, Action onManual, Action onAuto, Action<string> otherwise)
    {
        if (this == Disabled) onDisabled();
        else if (this == Manual) onManual();
        else if (this == Auto) onAuto();
        else otherwise(Value);
    }
}
