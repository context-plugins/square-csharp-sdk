using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of the payment request. For more information, see
/// <see href="https://developer.squareup.com/docs/invoices-api/create-publish-invoices#payment-requests">Configuring payment requests</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceRequestType>))]
public sealed record InvoiceRequestType : OpenStringEnum<InvoiceRequestType>
{
    private InvoiceRequestType(string value) : base(value)
    {
    }

    /// <summary>
    /// A request for a balance payment. The balance amount is computed as follows:
    /// <para>
    /// - If the invoice specifies only a balance payment request, the balance amount is the
    /// total amount of the associated order.
    /// - If the invoice also specifies a deposit request, the balance amount is the amount
    /// remaining after the deposit.
    /// </para>
    /// <para>
    /// <c>INSTALLMENT</c> and <c>BALANCE</c> payment requests are not allowed in the same invoice.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestType Balance = new("BALANCE");

    /// <summary>
    /// A request for a deposit payment. You have the option of specifying
    /// an exact amount or a percentage of the total order amount. If you request a deposit,
    /// it must be due before any other payment requests.
    /// </summary>
    public static readonly InvoiceRequestType Deposit = new("DEPOSIT");

    /// <summary>
    /// A request for an installment payment. Installments allow buyers to pay the invoice over time. Installments can optionally be combined with a deposit.
    /// <para>
    /// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestType Installment = new("INSTALLMENT");

    public TResult Match<TResult>(Func<TResult> onBalance,
        Func<TResult> onDeposit,
        Func<TResult> onInstallment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Balance => onBalance(),
            _ when this == Deposit => onDeposit(),
            _ when this == Installment => onInstallment(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalance, Action onDeposit, Action onInstallment, Action<string> otherwise)
    {
        if (this == Balance) onBalance();
        else if (this == Deposit) onDeposit();
        else if (this == Installment) onInstallment();
        else otherwise(Value);
    }
}
