using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The type of a CatalogItem. Connect V2 only allows the creation of <c>REGULAR</c> or <c>APPOINTMENTS_SERVICE</c> items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemProductType>))]
public sealed record CatalogItemProductType : StringEnum<CatalogItemProductType>
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

    public static CatalogItemProductType FromValue(string value) => FromValueCore(value);
}
