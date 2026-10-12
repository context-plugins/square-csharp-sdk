using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates which high-level category of error has occurred during a
/// request to the Connect API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCategory>))]
public sealed record ErrorCategory : OpenStringEnum<ErrorCategory>
{
    private ErrorCategory(string value) : base(value)
    {
    }

    /// <summary>
    /// An error occurred with the Connect API itself.
    /// </summary>
    public static readonly ErrorCategory ApiError = new("API_ERROR");

    /// <summary>
    /// An authentication error occurred. Most commonly, the request had
    /// a missing, malformed, or otherwise invalid <c>Authorization</c> header.
    /// </summary>
    public static readonly ErrorCategory AuthenticationError = new("AUTHENTICATION_ERROR");

    /// <summary>
    /// The request was invalid. Most commonly, a required parameter was
    /// missing, or a provided parameter had an invalid value.
    /// </summary>
    public static readonly ErrorCategory InvalidRequestError = new("INVALID_REQUEST_ERROR");

    /// <summary>
    /// Your application reached the Square API rate limit. You might receive this error if your application sends a high number of requests
    /// to Square APIs in a short period of time.
    /// <para>
    /// Your application should monitor responses for <c>429 RATE_LIMITED</c> errors and use a retry mechanism with an <see href="https://en.wikipedia.org/wiki/Exponential_backoff">exponential backoff</see>
    /// schedule to resend the requests at an increasingly slower rate. It is also a good practice to use a randomized delay (jitter) in your retry schedule.
    /// </para>
    /// </summary>
    public static readonly ErrorCategory RateLimitError = new("RATE_LIMIT_ERROR");

    /// <summary>
    /// An error occurred while processing a payment method. Most commonly,
    /// the details of the payment method were invalid (such as a card's CVV
    /// or expiration date).
    /// </summary>
    public static readonly ErrorCategory PaymentMethodError = new("PAYMENT_METHOD_ERROR");

    /// <summary>
    /// An error occurred while attempting to process a refund.
    /// </summary>
    public static readonly ErrorCategory RefundError = new("REFUND_ERROR");

    /// <summary>
    /// An error occurred when checking a merchant subscription status
    /// </summary>
    public static readonly ErrorCategory MerchantSubscriptionError = new("MERCHANT_SUBSCRIPTION_ERROR");

    /// <summary>
    /// An error that is returned from an external vendor's API
    /// </summary>
    public static readonly ErrorCategory ExternalVendorError = new("EXTERNAL_VENDOR_ERROR");

    public TResult Match<TResult>(Func<TResult> onApiError,
        Func<TResult> onAuthenticationError,
        Func<TResult> onInvalidRequestError,
        Func<TResult> onRateLimitError,
        Func<TResult> onPaymentMethodError,
        Func<TResult> onRefundError,
        Func<TResult> onMerchantSubscriptionError,
        Func<TResult> onExternalVendorError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ApiError => onApiError(),
            _ when this == AuthenticationError => onAuthenticationError(),
            _ when this == InvalidRequestError => onInvalidRequestError(),
            _ when this == RateLimitError => onRateLimitError(),
            _ when this == PaymentMethodError => onPaymentMethodError(),
            _ when this == RefundError => onRefundError(),
            _ when this == MerchantSubscriptionError => onMerchantSubscriptionError(),
            _ when this == ExternalVendorError => onExternalVendorError(),
            _ => otherwise(Value)
        };

    public void Match(Action onApiError,
        Action onAuthenticationError,
        Action onInvalidRequestError,
        Action onRateLimitError,
        Action onPaymentMethodError,
        Action onRefundError,
        Action onMerchantSubscriptionError,
        Action onExternalVendorError,
        Action<string> otherwise)
    {
        if (this == ApiError) onApiError();
        else if (this == AuthenticationError) onAuthenticationError();
        else if (this == InvalidRequestError) onInvalidRequestError();
        else if (this == RateLimitError) onRateLimitError();
        else if (this == PaymentMethodError) onPaymentMethodError();
        else if (this == RefundError) onRefundError();
        else if (this == MerchantSubscriptionError) onMerchantSubscriptionError();
        else if (this == ExternalVendorError) onExternalVendorError();
        else otherwise(Value);
    }
}
