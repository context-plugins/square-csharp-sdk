using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TenderSquareAccountDetailsStatus>))]
public sealed record TenderSquareAccountDetailsStatus : OpenStringEnum<TenderSquareAccountDetailsStatus>
{
    private TenderSquareAccountDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The Square Account payment has been authorized but not yet captured.
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Authorized = new("AUTHORIZED");

    /// <summary>
    /// The Square Account payment was authorized and subsequently captured (i.e., completed).
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Captured = new("CAPTURED");

    /// <summary>
    /// The Square Account payment was authorized and subsequently voided (i.e., canceled).
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Voided = new("VOIDED");

    /// <summary>
    /// The Square Account payment failed.
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Failed = new("FAILED");

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
