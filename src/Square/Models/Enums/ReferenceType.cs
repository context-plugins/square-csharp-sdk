using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of platform concept a channel can represent.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReferenceType>))]
public sealed record ReferenceType : OpenStringEnum<ReferenceType>
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

    public TResult Match<TResult>(Func<TResult> onUnknownType,
        Func<TResult> onLocation,
        Func<TResult> onFirstPartyIntegration,
        Func<TResult> onOauthApplication,
        Func<TResult> onOnlineSite,
        Func<TResult> onOnlineCheckout,
        Func<TResult> onInvoice,
        Func<TResult> onGiftCard,
        Func<TResult> onGiftCardMarketplace,
        Func<TResult> onRecurringSubscription,
        Func<TResult> onOnlineBookingFlow,
        Func<TResult> onSquareAssistant,
        Func<TResult> onCashLocal,
        Func<TResult> onPointOfSale,
        Func<TResult> onKiosk,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UnknownType => onUnknownType(),
            _ when this == Location => onLocation(),
            _ when this == FirstPartyIntegration => onFirstPartyIntegration(),
            _ when this == OauthApplication => onOauthApplication(),
            _ when this == OnlineSite => onOnlineSite(),
            _ when this == OnlineCheckout => onOnlineCheckout(),
            _ when this == Invoice => onInvoice(),
            _ when this == GiftCard => onGiftCard(),
            _ when this == GiftCardMarketplace => onGiftCardMarketplace(),
            _ when this == RecurringSubscription => onRecurringSubscription(),
            _ when this == OnlineBookingFlow => onOnlineBookingFlow(),
            _ when this == SquareAssistant => onSquareAssistant(),
            _ when this == CashLocal => onCashLocal(),
            _ when this == PointOfSale => onPointOfSale(),
            _ when this == Kiosk => onKiosk(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknownType,
        Action onLocation,
        Action onFirstPartyIntegration,
        Action onOauthApplication,
        Action onOnlineSite,
        Action onOnlineCheckout,
        Action onInvoice,
        Action onGiftCard,
        Action onGiftCardMarketplace,
        Action onRecurringSubscription,
        Action onOnlineBookingFlow,
        Action onSquareAssistant,
        Action onCashLocal,
        Action onPointOfSale,
        Action onKiosk,
        Action<string> otherwise)
    {
        if (this == UnknownType) onUnknownType();
        else if (this == Location) onLocation();
        else if (this == FirstPartyIntegration) onFirstPartyIntegration();
        else if (this == OauthApplication) onOauthApplication();
        else if (this == OnlineSite) onOnlineSite();
        else if (this == OnlineCheckout) onOnlineCheckout();
        else if (this == Invoice) onInvoice();
        else if (this == GiftCard) onGiftCard();
        else if (this == GiftCardMarketplace) onGiftCardMarketplace();
        else if (this == RecurringSubscription) onRecurringSubscription();
        else if (this == OnlineBookingFlow) onOnlineBookingFlow();
        else if (this == SquareAssistant) onSquareAssistant();
        else if (this == CashLocal) onCashLocal();
        else if (this == PointOfSale) onPointOfSale();
        else if (this == Kiosk) onKiosk();
        else otherwise(Value);
    }
}
