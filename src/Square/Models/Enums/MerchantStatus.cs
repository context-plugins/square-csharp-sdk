using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantStatus>))]
public sealed record MerchantStatus : OpenStringEnum<MerchantStatus>
{
    private MerchantStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// A fully operational merchant account. The merchant can interact with Square products and APIs.
    /// </summary>
    public static readonly MerchantStatus Active = new("ACTIVE");

    /// <summary>
    /// A functionally limited merchant account. The merchant can only have limited interaction
    /// via Square APIs. The merchant cannot log in or access the seller dashboard.
    /// </summary>
    public static readonly MerchantStatus Inactive = new("INACTIVE");

    public TResult Match<TResult>(Func<TResult> onActive, Func<TResult> onInactive, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else otherwise(Value);
    }
}
