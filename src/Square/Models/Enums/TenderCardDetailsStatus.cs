using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the card transaction's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderCardDetailsStatus>))]
public sealed record TenderCardDetailsStatus : OpenStringEnum<TenderCardDetailsStatus>
{
    private TenderCardDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The card transaction has been authorized but not yet captured.
    /// </summary>
    public static readonly TenderCardDetailsStatus Authorized = new("AUTHORIZED");

    /// <summary>
    /// The card transaction was authorized and subsequently captured (i.e., completed).
    /// </summary>
    public static readonly TenderCardDetailsStatus Captured = new("CAPTURED");

    /// <summary>
    /// The card transaction was authorized and subsequently voided (i.e., canceled).
    /// </summary>
    public static readonly TenderCardDetailsStatus Voided = new("VOIDED");

    /// <summary>
    /// The card transaction failed.
    /// </summary>
    public static readonly TenderCardDetailsStatus Failed = new("FAILED");

    public TResult Match<TResult>(Func<TResult> onAuthorized,
        Func<TResult> onCaptured,
        Func<TResult> onVoided,
        Func<TResult> onFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Authorized => onAuthorized(),
            _ when this == Captured => onCaptured(),
            _ when this == Voided => onVoided(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthorized,
        Action onCaptured,
        Action onVoided,
        Action onFailed,
        Action<string> otherwise)
    {
        if (this == Authorized) onAuthorized();
        else if (this == Captured) onCaptured();
        else if (this == Voided) onVoided();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
