using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The field to use for sorting.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceSortField>))]
public sealed record InvoiceSortField : OpenStringEnum<InvoiceSortField>
{
    private InvoiceSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The field works as follows:
    /// <list type="bullet">
    ///   <item><description>If the invoice is a draft, it uses the invoice <c>created_at</c> date.</description></item>
    ///   <item><description>If the invoice is scheduled for publication, it uses the <c>scheduled_at</c> date.</description></item>
    ///   <item><description>If the invoice is published, it uses the invoice publication date.</description></item>
    /// </list>
    /// </summary>
    public static readonly InvoiceSortField InvoiceSortDate = new("INVOICE_SORT_DATE");

    public TResult Match<TResult>(Func<TResult> onInvoiceSortDate, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvoiceSortDate => onInvoiceSortDate(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvoiceSortDate, Action<string> otherwise)
    {
        if (this == InvoiceSortDate) onInvoiceSortDate();
        else otherwise(Value);
    }
}
