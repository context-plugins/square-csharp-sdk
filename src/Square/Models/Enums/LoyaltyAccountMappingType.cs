using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of mapping.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyAccountMappingType>))]
public sealed record LoyaltyAccountMappingType : OpenStringEnum<LoyaltyAccountMappingType>
{
    private LoyaltyAccountMappingType(string value) : base(value)
    {
    }

    /// <summary>
    /// The loyalty account is mapped by phone.
    /// </summary>
    public static readonly LoyaltyAccountMappingType Phone = new("PHONE");

    public TResult Match<TResult>(Func<TResult> onPhone, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Phone => onPhone(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhone, Action<string> otherwise)
    {
        if (this == Phone) onPhone();
        else otherwise(Value);
    }
}
