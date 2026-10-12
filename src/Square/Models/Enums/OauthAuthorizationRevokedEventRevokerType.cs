using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the possible types for the revoking client.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OauthAuthorizationRevokedEventRevokerType>))]
public sealed record OauthAuthorizationRevokedEventRevokerType : OpenStringEnum<OauthAuthorizationRevokedEventRevokerType>
{
    private OauthAuthorizationRevokedEventRevokerType(string value) : base(value)
    {
    }

    /// <summary>
    /// The application that requested access to a merchant's data.
    /// </summary>
    public static readonly OauthAuthorizationRevokedEventRevokerType Application = new("APPLICATION");

    /// <summary>
    /// The admin for the merchant.
    /// </summary>
    public static readonly OauthAuthorizationRevokedEventRevokerType Merchant = new("MERCHANT");

    /// <summary>
    /// An internal Square employee.
    /// </summary>
    public static readonly OauthAuthorizationRevokedEventRevokerType Square = new("SQUARE");

    public TResult Match<TResult>(Func<TResult> onApplication,
        Func<TResult> onMerchant,
        Func<TResult> onSquare,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Application => onApplication(),
            _ when this == Merchant => onMerchant(),
            _ when this == Square => onSquare(),
            _ => otherwise(Value)
        };

    public void Match(Action onApplication, Action onMerchant, Action onSquare, Action<string> otherwise)
    {
        if (this == Application) onApplication();
        else if (this == Merchant) onMerchant();
        else if (this == Square) onSquare();
        else otherwise(Value);
    }
}
