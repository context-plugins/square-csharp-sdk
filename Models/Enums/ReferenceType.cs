using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of platform concept a channel can represent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReferenceType>))]
public sealed record ReferenceType : StringEnum<ReferenceType>
{
    private ReferenceType(string value) : base(value)
    {
    }

    public static readonly ReferenceType UnknownType = new("UNKNOWN_TYPE");

    public static readonly ReferenceType Location = new("LOCATION");

    public static readonly ReferenceType FirstPartyIntegration = new("FIRST_PARTY_INTEGRATION");

    public static readonly ReferenceType OauthApplication = new("OAUTH_APPLICATION");

    public static readonly ReferenceType OnlineSite = new("ONLINE_SITE");

    public static readonly ReferenceType OnlineCheckout = new("ONLINE_CHECKOUT");

    public static readonly ReferenceType Invoice = new("INVOICE");

    public static readonly ReferenceType GiftCard = new("GIFT_CARD");

    public static readonly ReferenceType GiftCardMarketplace = new("GIFT_CARD_MARKETPLACE");

    public static readonly ReferenceType RecurringSubscription = new("RECURRING_SUBSCRIPTION");

    public static readonly ReferenceType OnlineBookingFlow = new("ONLINE_BOOKING_FLOW");

    public static readonly ReferenceType SquareAssistant = new("SQUARE_ASSISTANT");

    public static readonly ReferenceType CashLocal = new("CASH_LOCAL");

    public static readonly ReferenceType PointOfSale = new("POINT_OF_SALE");

    public static readonly ReferenceType Kiosk = new("KIOSK");

    public static ReferenceType FromValue(string value) => FromValueCore(value);
}
