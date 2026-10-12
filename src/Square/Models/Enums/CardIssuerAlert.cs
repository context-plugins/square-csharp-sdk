using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the type of issuer alert for a <see href="entity:Card">card on file</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardIssuerAlert>))]
public sealed record CardIssuerAlert : OpenStringEnum<CardIssuerAlert>
{
    private CardIssuerAlert(string value) : base(value)
    {
    }

    /// <summary>
    /// The underlying account of the card was closed, which is a strong signal that future
    /// charges to the card are likely to fail.
    /// </summary>
    public static readonly CardIssuerAlert IssuerAlertCardClosed = new("ISSUER_ALERT_CARD_CLOSED");

    public TResult Match<TResult>(Func<TResult> onIssuerAlertCardClosed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IssuerAlertCardClosed => onIssuerAlertCardClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onIssuerAlertCardClosed, Action<string> otherwise)
    {
        if (this == IssuerAlertCardClosed) onIssuerAlertCardClosed();
        else otherwise(Value);
    }
}
