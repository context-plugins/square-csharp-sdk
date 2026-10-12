using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Represents the line item type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemItemType>))]
public sealed record OrderLineItemItemType : OpenStringEnum<OrderLineItemItemType>
{
    private OrderLineItemItemType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the line item is an itemized sale.
    /// </summary>
    public static readonly OrderLineItemItemType Item = new("ITEM");

    /// <summary>
    /// Indicates that the line item is a non-itemized sale.
    /// </summary>
    public static readonly OrderLineItemItemType CustomAmount = new("CUSTOM_AMOUNT");

    /// <summary>
    /// Indicates that the line item is a gift card sale. Gift cards sold through
    /// the Orders API are sold in an unactivated state and can be activated through the
    /// Gift Cards API using the line item <c>uid</c>.
    /// </summary>
    public static readonly OrderLineItemItemType GiftCard = new("GIFT_CARD");

    public TResult Match<TResult>(Func<TResult> onItem,
        Func<TResult> onCustomAmount,
        Func<TResult> onGiftCard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Item => onItem(),
            _ when this == CustomAmount => onCustomAmount(),
            _ when this == GiftCard => onGiftCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onItem, Action onCustomAmount, Action onGiftCard, Action<string> otherwise)
    {
        if (this == Item) onItem();
        else if (this == CustomAmount) onCustomAmount();
        else if (this == GiftCard) onGiftCard();
        else otherwise(Value);
    }
}
