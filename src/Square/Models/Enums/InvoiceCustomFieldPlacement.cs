using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates where to render a custom field on the Square-hosted invoice page and in emailed or PDF
/// copies of the invoice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceCustomFieldPlacement>))]
public sealed record InvoiceCustomFieldPlacement : OpenStringEnum<InvoiceCustomFieldPlacement>
{
    private InvoiceCustomFieldPlacement(string value) : base(value)
    {
    }

    /// <summary>
    /// Render the custom field above the invoice line items.
    /// </summary>
    public static readonly InvoiceCustomFieldPlacement AboveLineItems = new("ABOVE_LINE_ITEMS");

    /// <summary>
    /// Render the custom field below the invoice line items.
    /// </summary>
    public static readonly InvoiceCustomFieldPlacement BelowLineItems = new("BELOW_LINE_ITEMS");

    public TResult Match<TResult>(Func<TResult> onAboveLineItems,
        Func<TResult> onBelowLineItems,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AboveLineItems => onAboveLineItems(),
            _ when this == BelowLineItems => onBelowLineItems(),
            _ => otherwise(Value)
        };

    public void Match(Action onAboveLineItems, Action onBelowLineItems, Action<string> otherwise)
    {
        if (this == AboveLineItems) onAboveLineItems();
        else if (this == BelowLineItems) onBelowLineItems();
        else otherwise(Value);
    }
}
