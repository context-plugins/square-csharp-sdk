using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Defines the possible types for the revoking client.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OauthAuthorizationRevokedEventRevokerType>))]
public sealed record OauthAuthorizationRevokedEventRevokerType : StringEnum<OauthAuthorizationRevokedEventRevokerType>
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

    public static OauthAuthorizationRevokedEventRevokerType FromValue(string value) => FromValueCore(value);
}
