using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported info codes of a subscription event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionEventInfoCode>))]
public sealed record SubscriptionEventInfoCode : OpenStringEnum<SubscriptionEventInfoCode>
{
    private SubscriptionEventInfoCode(string value) : base(value)
    {
    }

    /// <summary>
    /// The location is not active.
    /// </summary>
    public static readonly SubscriptionEventInfoCode LocationNotActive = new("LOCATION_NOT_ACTIVE");

    /// <summary>
    /// The location cannot accept payments.
    /// </summary>
    public static readonly SubscriptionEventInfoCode LocationCannotAcceptPayment = new(
        "LOCATION_CANNOT_ACCEPT_PAYMENT");

    /// <summary>
    /// The subscribing customer profile has been deleted.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerDeleted = new("CUSTOMER_DELETED");

    /// <summary>
    /// The subscribing customer does not have an email.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerNoEmail = new("CUSTOMER_NO_EMAIL");

    /// <summary>
    /// The subscribing customer does not have a name.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerNoName = new("CUSTOMER_NO_NAME");

    /// <summary>
    /// User-provided detail.
    /// </summary>
    public static readonly SubscriptionEventInfoCode UserProvided = new("USER_PROVIDED");

    public TResult Match<TResult>(Func<TResult> onLocationNotActive,
        Func<TResult> onLocationCannotAcceptPayment,
        Func<TResult> onCustomerDeleted,
        Func<TResult> onCustomerNoEmail,
        Func<TResult> onCustomerNoName,
        Func<TResult> onUserProvided,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LocationNotActive => onLocationNotActive(),
            _ when this == LocationCannotAcceptPayment => onLocationCannotAcceptPayment(),
            _ when this == CustomerDeleted => onCustomerDeleted(),
            _ when this == CustomerNoEmail => onCustomerNoEmail(),
            _ when this == CustomerNoName => onCustomerNoName(),
            _ when this == UserProvided => onUserProvided(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocationNotActive,
        Action onLocationCannotAcceptPayment,
        Action onCustomerDeleted,
        Action onCustomerNoEmail,
        Action onCustomerNoName,
        Action onUserProvided,
        Action<string> otherwise)
    {
        if (this == LocationNotActive) onLocationNotActive();
        else if (this == LocationCannotAcceptPayment) onLocationCannotAcceptPayment();
        else if (this == CustomerDeleted) onCustomerDeleted();
        else if (this == CustomerNoEmail) onCustomerNoEmail();
        else if (this == CustomerNoName) onCustomerNoName();
        else if (this == UserProvided) onUserProvided();
        else otherwise(Value);
    }
}
