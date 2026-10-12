using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Determines item visibility in Ecom (Online Store) and Online Checkout.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EcomVisibility>))]
public sealed record EcomVisibility : OpenStringEnum<EcomVisibility>
{
    private EcomVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Item is not synced with Ecom (Weebly). This is the default state
    /// </summary>
    public static readonly EcomVisibility Unindexed = new("UNINDEXED");

    /// <summary>
    /// Item is synced but is unavailable within Ecom (Weebly) and Online Checkout
    /// </summary>
    public static readonly EcomVisibility Unavailable = new("UNAVAILABLE");

    /// <summary>
    /// Option for seller to choose manually created Quick Amounts.
    /// </summary>
    public static readonly EcomVisibility Hidden = new("HIDDEN");

    /// <summary>
    /// Item is synced but available within Ecom (Weebly) and Online Checkout but is hidden from Ecom Store.
    /// </summary>
    public static readonly EcomVisibility Visible = new("VISIBLE");

    public TResult Match<TResult>(Func<TResult> onUnindexed,
        Func<TResult> onUnavailable,
        Func<TResult> onHidden,
        Func<TResult> onVisible,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unindexed => onUnindexed(),
            _ when this == Unavailable => onUnavailable(),
            _ when this == Hidden => onHidden(),
            _ when this == Visible => onVisible(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnindexed,
        Action onUnavailable,
        Action onHidden,
        Action onVisible,
        Action<string> otherwise)
    {
        if (this == Unindexed) onUnindexed();
        else if (this == Unavailable) onUnavailable();
        else if (this == Hidden) onHidden();
        else if (this == Visible) onVisible();
        else otherwise(Value);
    }
}
