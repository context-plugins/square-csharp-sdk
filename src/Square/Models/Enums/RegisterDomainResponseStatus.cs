using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the domain registration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RegisterDomainResponseStatus>))]
public sealed record RegisterDomainResponseStatus : OpenStringEnum<RegisterDomainResponseStatus>
{
    private RegisterDomainResponseStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The domain is added, but not verified.
    /// </summary>
    public static readonly RegisterDomainResponseStatus Pending = new("PENDING");

    /// <summary>
    /// The domain is added and verified. It can be used to accept Apple Pay transactions.
    /// </summary>
    public static readonly RegisterDomainResponseStatus Verified = new("VERIFIED");

    public TResult Match<TResult>(Func<TResult> onPending, Func<TResult> onVerified, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Verified => onVerified(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onVerified, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Verified) onVerified();
        else otherwise(Value);
    }
}
