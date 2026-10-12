using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of a CatalogItem. Connect V2 only allows the creation of <c>REGULAR</c> or <c>APPOINTMENTS_SERVICE</c> items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemProductType>))]
public sealed record CatalogItemProductType : OpenStringEnum<CatalogItemProductType>
{
    private CatalogItemProductType(string value) : base(value)
    {
    }

    /// <summary>
    /// An ordinary item.
    /// </summary>
    public static readonly CatalogItemProductType Regular = new("REGULAR");

    /// <summary>
    /// A Square gift card.
    /// </summary>
    public static readonly CatalogItemProductType GiftCard = new("GIFT_CARD");

    /// <summary>
    /// A service that can be booked using the Square Appointments app.
    /// </summary>
    public static readonly CatalogItemProductType AppointmentsService = new("APPOINTMENTS_SERVICE");

    /// <summary>
    /// A food or beverage item that can be sold by restaurants and other food venues.
    /// </summary>
    public static readonly CatalogItemProductType FoodAndBev = new("FOOD_AND_BEV");

    /// <summary>
    /// An event which tickets can be sold for, including location, address, and times.
    /// </summary>
    public static readonly CatalogItemProductType Event = new("EVENT");

    /// <summary>
    /// A digital item like an ebook or song.
    /// </summary>
    public static readonly CatalogItemProductType Digital = new("DIGITAL");

    /// <summary>
    /// A donation which site visitors can send for any cause.
    /// </summary>
    public static readonly CatalogItemProductType Donation = new("DONATION");

    /// <summary>
    /// A legacy Square Online service that is manually fulfilled. This corresponds to the <c>Other</c> item type displayed in the Square Seller Dashboard and Square POS apps.
    /// </summary>
    public static readonly CatalogItemProductType LegacySquareOnlineService = new("LEGACY_SQUARE_ONLINE_SERVICE");

    /// <summary>
    /// A legacy Square Online membership that is manually fulfilled. This corresponds to the <c>Membership</c> item type displayed in the Square Seller Dashboard and Square POS apps.
    /// </summary>
    public static readonly CatalogItemProductType LegacySquareOnlineMembership = new("LEGACY_SQUARE_ONLINE_MEMBERSHIP");

    public TResult Match<TResult>(Func<TResult> onRegular,
        Func<TResult> onGiftCard,
        Func<TResult> onAppointmentsService,
        Func<TResult> onFoodAndBev,
        Func<TResult> onEvent,
        Func<TResult> onDigital,
        Func<TResult> onDonation,
        Func<TResult> onLegacySquareOnlineService,
        Func<TResult> onLegacySquareOnlineMembership,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Regular => onRegular(),
            _ when this == GiftCard => onGiftCard(),
            _ when this == AppointmentsService => onAppointmentsService(),
            _ when this == FoodAndBev => onFoodAndBev(),
            _ when this == Event => onEvent(),
            _ when this == Digital => onDigital(),
            _ when this == Donation => onDonation(),
            _ when this == LegacySquareOnlineService => onLegacySquareOnlineService(),
            _ when this == LegacySquareOnlineMembership => onLegacySquareOnlineMembership(),
            _ => otherwise(Value)
        };

    public void Match(Action onRegular,
        Action onGiftCard,
        Action onAppointmentsService,
        Action onFoodAndBev,
        Action onEvent,
        Action onDigital,
        Action onDonation,
        Action onLegacySquareOnlineService,
        Action onLegacySquareOnlineMembership,
        Action<string> otherwise)
    {
        if (this == Regular) onRegular();
        else if (this == GiftCard) onGiftCard();
        else if (this == AppointmentsService) onAppointmentsService();
        else if (this == FoodAndBev) onFoodAndBev();
        else if (this == Event) onEvent();
        else if (this == Digital) onDigital();
        else if (this == Donation) onDonation();
        else if (this == LegacySquareOnlineService) onLegacySquareOnlineService();
        else if (this == LegacySquareOnlineMembership) onLegacySquareOnlineMembership();
        else otherwise(Value);
    }
}
