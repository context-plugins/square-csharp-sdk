using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Indicates the specific error that occurred during a request to a
/// Square API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCode>))]
public sealed record ErrorCode : OpenStringEnum<ErrorCode>
{
    private ErrorCode(string value) : base(value)
    {
    }

    /// <summary>
    /// A general server error occurred.
    /// </summary>
    public static readonly ErrorCode InternalServerError = new("INTERNAL_SERVER_ERROR");

    /// <summary>
    /// A general authorization error occurred.
    /// </summary>
    public static readonly ErrorCode Unauthorized = new("UNAUTHORIZED");

    /// <summary>
    /// The provided access token has expired.
    /// </summary>
    public static readonly ErrorCode AccessTokenExpired = new("ACCESS_TOKEN_EXPIRED");

    /// <summary>
    /// The provided access token has been revoked.
    /// </summary>
    public static readonly ErrorCode AccessTokenRevoked = new("ACCESS_TOKEN_REVOKED");

    /// <summary>
    /// The provided client has been disabled.
    /// </summary>
    public static readonly ErrorCode ClientDisabled = new("CLIENT_DISABLED");

    /// <summary>
    /// A general access error occurred.
    /// </summary>
    public static readonly ErrorCode Forbidden = new("FORBIDDEN");

    /// <summary>
    /// The provided access token does not have permission
    /// to execute the requested action.
    /// </summary>
    public static readonly ErrorCode InsufficientScopes = new("INSUFFICIENT_SCOPES");

    /// <summary>
    /// The calling application was disabled.
    /// </summary>
    public static readonly ErrorCode ApplicationDisabled = new("APPLICATION_DISABLED");

    /// <summary>
    /// The calling application was created prior to
    /// 2016-03-30 and is not compatible with v2 Square API calls.
    /// </summary>
    public static readonly ErrorCode V1Application = new("V1_APPLICATION");

    /// <summary>
    /// The calling application is using an access token
    /// created prior to 2016-03-30 and is not compatible with v2 Square API
    /// calls.
    /// </summary>
    public static readonly ErrorCode V1AccessToken = new("V1_ACCESS_TOKEN");

    /// <summary>
    /// The location provided in the API call is not
    /// enabled for credit card processing.
    /// </summary>
    public static readonly ErrorCode CardProcessingNotEnabled = new("CARD_PROCESSING_NOT_ENABLED");

    /// <summary>
    /// A required subscription was not found for the merchant
    /// </summary>
    public static readonly ErrorCode MerchantSubscriptionNotFound = new("MERCHANT_SUBSCRIPTION_NOT_FOUND");

    /// <summary>
    /// A general error occurred with the request.
    /// </summary>
    public static readonly ErrorCode BadRequest = new("BAD_REQUEST");

    /// <summary>
    /// The request is missing a required path, query, or
    /// body parameter.
    /// </summary>
    public static readonly ErrorCode MissingRequiredParameter = new("MISSING_REQUIRED_PARAMETER");

    /// <summary>
    /// The value provided in the request is the wrong
    /// type. For example, a string instead of an integer.
    /// </summary>
    public static readonly ErrorCode IncorrectType = new("INCORRECT_TYPE");

    /// <summary>
    /// Formatting for the provided time value is
    /// incorrect.
    /// </summary>
    public static readonly ErrorCode InvalidTime = new("INVALID_TIME");

    /// <summary>
    /// The time range provided in the request is invalid.
    /// For example, the end time is before the start time.
    /// </summary>
    public static readonly ErrorCode InvalidTimeRange = new("INVALID_TIME_RANGE");

    /// <summary>
    /// The provided value is invalid. For example,
    /// including <c>%</c> in a phone number.
    /// </summary>
    public static readonly ErrorCode InvalidValue = new("INVALID_VALUE");

    /// <summary>
    /// The pagination cursor included in the request is
    /// invalid.
    /// </summary>
    public static readonly ErrorCode InvalidCursor = new("INVALID_CURSOR");

    /// <summary>
    /// The query parameters provided is invalid for the
    /// requested endpoint.
    /// </summary>
    public static readonly ErrorCode UnknownQueryParameter = new("UNKNOWN_QUERY_PARAMETER");

    /// <summary>
    /// One or more of the request parameters conflict with
    /// each other.
    /// </summary>
    public static readonly ErrorCode ConflictingParameters = new("CONFLICTING_PARAMETERS");

    /// <summary>
    /// The request body is not a JSON object.
    /// </summary>
    public static readonly ErrorCode ExpectedJsonBody = new("EXPECTED_JSON_BODY");

    /// <summary>
    /// The provided sort order is not a valid key.
    /// Currently, sort order must be <c>ASC</c> or <c>DESC</c>.
    /// </summary>
    public static readonly ErrorCode InvalidSortOrder = new("INVALID_SORT_ORDER");

    /// <summary>
    /// The provided value does not match an expected
    /// regular expression.
    /// </summary>
    public static readonly ErrorCode ValueRegexMismatch = new("VALUE_REGEX_MISMATCH");

    /// <summary>
    /// The provided string value is shorter than the
    /// minimum length allowed.
    /// </summary>
    public static readonly ErrorCode ValueTooShort = new("VALUE_TOO_SHORT");

    /// <summary>
    /// The provided string value is longer than the
    /// maximum length allowed.
    /// </summary>
    public static readonly ErrorCode ValueTooLong = new("VALUE_TOO_LONG");

    /// <summary>
    /// The provided value is less than the supported
    /// minimum.
    /// </summary>
    public static readonly ErrorCode ValueTooLow = new("VALUE_TOO_LOW");

    /// <summary>
    /// The provided value is greater than the supported
    /// maximum.
    /// </summary>
    public static readonly ErrorCode ValueTooHigh = new("VALUE_TOO_HIGH");

    /// <summary>
    /// The provided value has a default (empty) value
    /// such as a blank string.
    /// </summary>
    public static readonly ErrorCode ValueEmpty = new("VALUE_EMPTY");

    /// <summary>
    /// The provided array has too many elements.
    /// </summary>
    public static readonly ErrorCode ArrayLengthTooLong = new("ARRAY_LENGTH_TOO_LONG");

    /// <summary>
    /// The provided array has too few elements.
    /// </summary>
    public static readonly ErrorCode ArrayLengthTooShort = new("ARRAY_LENGTH_TOO_SHORT");

    /// <summary>
    /// The provided array is empty.
    /// </summary>
    public static readonly ErrorCode ArrayEmpty = new("ARRAY_EMPTY");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// boolean.
    /// </summary>
    public static readonly ErrorCode ExpectedBoolean = new("EXPECTED_BOOLEAN");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// integer.
    /// </summary>
    public static readonly ErrorCode ExpectedInteger = new("EXPECTED_INTEGER");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// float.
    /// </summary>
    public static readonly ErrorCode ExpectedFloat = new("EXPECTED_FLOAT");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// string.
    /// </summary>
    public static readonly ErrorCode ExpectedString = new("EXPECTED_STRING");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// JSON object.
    /// </summary>
    public static readonly ErrorCode ExpectedObject = new("EXPECTED_OBJECT");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// array or list.
    /// </summary>
    public static readonly ErrorCode ExpectedArray = new("EXPECTED_ARRAY");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// map or associative array.
    /// </summary>
    public static readonly ErrorCode ExpectedMap = new("EXPECTED_MAP");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// array encoded in base64.
    /// </summary>
    public static readonly ErrorCode ExpectedBase64EncodedByteArray = new("EXPECTED_BASE64_ENCODED_BYTE_ARRAY");

    /// <summary>
    /// One or more objects in the array does not match the
    /// array type.
    /// </summary>
    public static readonly ErrorCode InvalidArrayValue = new("INVALID_ARRAY_VALUE");

    /// <summary>
    /// The provided static string is not valid for the
    /// field.
    /// </summary>
    public static readonly ErrorCode InvalidEnumValue = new("INVALID_ENUM_VALUE");

    /// <summary>
    /// Invalid content type header.
    /// </summary>
    public static readonly ErrorCode InvalidContentType = new("INVALID_CONTENT_TYPE");

    /// <summary>
    /// Only relevant for applications created prior to
    /// 2016-03-30. Indicates there was an error while parsing form values.
    /// </summary>
    public static readonly ErrorCode InvalidFormValue = new("INVALID_FORM_VALUE");

    /// <summary>
    /// The provided customer id can't be found in the merchant's customers list.
    /// </summary>
    public static readonly ErrorCode CustomerNotFound = new("CUSTOMER_NOT_FOUND");

    /// <summary>
    /// A general error occurred.
    /// </summary>
    public static readonly ErrorCode OneInstrumentExpected = new("ONE_INSTRUMENT_EXPECTED");

    /// <summary>
    /// A general error occurred.
    /// </summary>
    public static readonly ErrorCode NoFieldsSet = new("NO_FIELDS_SET");

    /// <summary>
    /// Too many entries in the map field.
    /// </summary>
    public static readonly ErrorCode TooManyMapEntries = new("TOO_MANY_MAP_ENTRIES");

    /// <summary>
    /// The length of one of the provided keys in the map is too short.
    /// </summary>
    public static readonly ErrorCode MapKeyLengthTooShort = new("MAP_KEY_LENGTH_TOO_SHORT");

    /// <summary>
    /// The length of one of the provided keys in the map is too long.
    /// </summary>
    public static readonly ErrorCode MapKeyLengthTooLong = new("MAP_KEY_LENGTH_TOO_LONG");

    /// <summary>
    /// The provided customer does not have a recorded name.
    /// </summary>
    public static readonly ErrorCode CustomerMissingName = new("CUSTOMER_MISSING_NAME");

    /// <summary>
    /// The provided customer does not have a recorded email.
    /// </summary>
    public static readonly ErrorCode CustomerMissingEmail = new("CUSTOMER_MISSING_EMAIL");

    /// <summary>
    /// The subscription cannot be paused longer than the duration of the current phase.
    /// </summary>
    public static readonly ErrorCode InvalidPauseLength = new("INVALID_PAUSE_LENGTH");

    /// <summary>
    /// The subscription cannot be paused/resumed on the given date.
    /// </summary>
    public static readonly ErrorCode InvalidDate = new("INVALID_DATE");

    /// <summary>
    /// The API request references an unsupported country.
    /// </summary>
    public static readonly ErrorCode UnsupportedCountry = new("UNSUPPORTED_COUNTRY");

    /// <summary>
    /// The API request references an unsupported currency.
    /// </summary>
    public static readonly ErrorCode UnsupportedCurrency = new("UNSUPPORTED_CURRENCY");

    /// <summary>
    /// The payment was declined by the card issuer during an Apple Tap to Pay (TTP)
    /// transaction with a request for the card's PIN. This code will be returned alongside
    /// <c>CARD_DECLINED_VERIFICATION_REQUIRED</c> as a supplemental error, and will include an
    /// issuer-provided token in the <c>details</c> field that is needed to initiate the PIN
    /// collection flow on the iOS device.
    /// </summary>
    public static readonly ErrorCode AppleTtpPinToken = new("APPLE_TTP_PIN_TOKEN");

    /// <summary>
    /// The card issuer declined the request because the card is expired.
    /// </summary>
    public static readonly ErrorCode CardExpired = new("CARD_EXPIRED");

    /// <summary>
    /// The expiration date for the payment card is invalid. For example,
    /// it indicates a date in the past.
    /// </summary>
    public static readonly ErrorCode InvalidExpiration = new("INVALID_EXPIRATION");

    /// <summary>
    /// The expiration year for the payment card is invalid. For example,
    /// it indicates a year in the past or contains invalid characters.
    /// </summary>
    public static readonly ErrorCode InvalidExpirationYear = new("INVALID_EXPIRATION_YEAR");

    /// <summary>
    /// The expiration date for the payment card is invalid. For example,
    /// it contains invalid characters.
    /// </summary>
    public static readonly ErrorCode InvalidExpirationDate = new("INVALID_EXPIRATION_DATE");

    /// <summary>
    /// The credit card provided is not from a supported issuer.
    /// </summary>
    public static readonly ErrorCode UnsupportedCardBrand = new("UNSUPPORTED_CARD_BRAND");

    /// <summary>
    /// The entry method for the credit card (swipe, dip, tap) is not supported.
    /// </summary>
    public static readonly ErrorCode UnsupportedEntryMethod = new("UNSUPPORTED_ENTRY_METHOD");

    /// <summary>
    /// The encrypted card information is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidEncryptedCard = new("INVALID_ENCRYPTED_CARD");

    /// <summary>
    /// The credit card cannot be validated based on the provided details.
    /// </summary>
    public static readonly ErrorCode InvalidCard = new("INVALID_CARD");

    /// <summary>
    /// The payment was declined because there was a payment amount mismatch.
    /// The money amount Square was expecting does not match the amount provided.
    /// </summary>
    public static readonly ErrorCode PaymentAmountMismatch = new("PAYMENT_AMOUNT_MISMATCH");

    /// <summary>
    /// Square received a decline without any additional information.
    /// If the payment information seems correct, the buyer can contact their
    /// issuer to ask for more information.
    /// </summary>
    public static readonly ErrorCode GenericDecline = new("GENERIC_DECLINE");

    /// <summary>
    /// The card issuer declined the request because the CVV value is invalid.
    /// </summary>
    public static readonly ErrorCode CvvFailure = new("CVV_FAILURE");

    /// <summary>
    /// The card issuer declined the request because the postal code is invalid.
    /// </summary>
    public static readonly ErrorCode AddressVerificationFailure = new("ADDRESS_VERIFICATION_FAILURE");

    /// <summary>
    /// The issuer was not able to locate the account on record.
    /// </summary>
    public static readonly ErrorCode InvalidAccount = new("INVALID_ACCOUNT");

    /// <summary>
    /// The currency associated with the payment is not valid for the provided
    /// funding source. For example, a gift card funded in USD cannot be used to process
    /// payments in GBP.
    /// </summary>
    public static readonly ErrorCode CurrencyMismatch = new("CURRENCY_MISMATCH");

    /// <summary>
    /// The funding source has insufficient funds to cover the payment.
    /// </summary>
    public static readonly ErrorCode InsufficientFunds = new("INSUFFICIENT_FUNDS");

    /// <summary>
    /// The Square account does not have the permissions to accept
    /// this payment. For example, Square may limit which merchants are
    /// allowed to receive gift card payments.
    /// </summary>
    public static readonly ErrorCode InsufficientPermissions = new("INSUFFICIENT_PERMISSIONS");

    /// <summary>
    /// The card issuer has declined the transaction due to restrictions on where the card can be used.
    /// For example, a gift card is limited to a single merchant.
    /// </summary>
    public static readonly ErrorCode CardholderInsufficientPermissions = new("CARDHOLDER_INSUFFICIENT_PERMISSIONS");

    /// <summary>
    /// The Square account cannot take payments in the specified region.
    /// A Square account can take payments only from the region where the account was created.
    /// </summary>
    public static readonly ErrorCode InvalidLocation = new("INVALID_LOCATION");

    /// <summary>
    /// The card issuer has determined the payment amount is either too high or too low.
    /// The API returns the error code mostly for credit cards (for example, the card reached
    /// the credit limit). However, sometimes the issuer bank can indicate the error for debit
    /// or prepaid cards (for example, card has insufficient funds).
    /// </summary>
    public static readonly ErrorCode TransactionLimit = new("TRANSACTION_LIMIT");

    /// <summary>
    /// The card issuer declined the request because the issuer requires voice authorization from the cardholder. The seller should ask the customer to contact the card issuing bank to authorize the payment.
    /// </summary>
    public static readonly ErrorCode VoiceFailure = new("VOICE_FAILURE");

    /// <summary>
    /// The specified card number is invalid. For example, it is of
    /// incorrect length or is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode PanFailure = new("PAN_FAILURE");

    /// <summary>
    /// The card expiration date is either invalid or indicates that the
    /// card is expired.
    /// </summary>
    public static readonly ErrorCode ExpirationFailure = new("EXPIRATION_FAILURE");

    /// <summary>
    /// The card is not supported either in the geographic region or by
    /// the <see href="https://developer.squareup.com/docs/locations-api#initialize-a-merchant-category-code">merchant category code</see> (MCC).
    /// </summary>
    public static readonly ErrorCode CardNotSupported = new("CARD_NOT_SUPPORTED");

    /// <summary>
    /// The Square Card Reader declined the payment for an unknown reason.
    /// </summary>
    public static readonly ErrorCode ReaderDeclined = new("READER_DECLINED");

    /// <summary>
    /// The card issuer declined the request because the PIN is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidPin = new("INVALID_PIN");

    /// <summary>
    /// The payment is missing a required PIN.
    /// </summary>
    public static readonly ErrorCode MissingPin = new("MISSING_PIN");

    /// <summary>
    /// The payment is missing a required ACCOUNT_TYPE parameter.
    /// </summary>
    public static readonly ErrorCode MissingAccountType = new("MISSING_ACCOUNT_TYPE");

    /// <summary>
    /// The postal code is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode InvalidPostalCode = new("INVALID_POSTAL_CODE");

    /// <summary>
    /// The app_fee_money on a payment is too high.
    /// </summary>
    public static readonly ErrorCode InvalidFees = new("INVALID_FEES");

    /// <summary>
    /// The card must be swiped, tapped, or dipped. Payments attempted by manually entering the card number are declined.
    /// </summary>
    public static readonly ErrorCode ManuallyEnteredPaymentNotSupported = new("MANUALLY_ENTERED_PAYMENT_NOT_SUPPORTED");

    /// <summary>
    /// Square declined the request because the payment amount exceeded the processing limit for this merchant.
    /// </summary>
    public static readonly ErrorCode PaymentLimitExceeded = new("PAYMENT_LIMIT_EXCEEDED");

    /// <summary>
    /// Provides the available balance on a Square gift card when a gift card payment fails due to insufficient funds.
    /// This error is returned with an <c>INSUFFICIENT_FUNDS</c> error and contains the balance in the smallest denomination
    /// of the applicable currency. <see href="https://developer.squareup.com/docs/payments-api/error-codes#gift_card_available_amount">Learn more</see>
    /// about this error code.
    /// <para>
    /// You can use the <c>accept_partial_authorization</c> field in a <c>CreatePayment</c> request to configure a payment flow that uses
    /// the available balance and allows collecting additional payments.
    /// </para>
    /// </summary>
    public static readonly ErrorCode GiftCardAvailableAmount = new("GIFT_CARD_AVAILABLE_AMOUNT");

    /// <summary>
    /// The account provided cannot carry out transactions.
    /// </summary>
    public static readonly ErrorCode AccountUnusable = new("ACCOUNT_UNUSABLE");

    /// <summary>
    /// Bank account rejected or was not authorized for the payment.
    /// </summary>
    public static readonly ErrorCode BuyerRefusedPayment = new("BUYER_REFUSED_PAYMENT");

    /// <summary>
    /// The application tried to update a delayed-capture payment that has expired.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionExpired = new("DELAYED_TRANSACTION_EXPIRED");

    /// <summary>
    /// The application tried to cancel a delayed-capture payment that was already cancelled.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionCanceled = new("DELAYED_TRANSACTION_CANCELED");

    /// <summary>
    /// The application tried to capture a delayed-capture payment that was already captured.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionCaptured = new("DELAYED_TRANSACTION_CAPTURED");

    /// <summary>
    /// The application tried to update a delayed-capture payment that failed.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionFailed = new("DELAYED_TRANSACTION_FAILED");

    /// <summary>
    /// The provided card token (nonce) has expired.
    /// </summary>
    public static readonly ErrorCode CardTokenExpired = new("CARD_TOKEN_EXPIRED");

    /// <summary>
    /// The provided card token (nonce) was already used to process the payment or refund.
    /// </summary>
    public static readonly ErrorCode CardTokenUsed = new("CARD_TOKEN_USED");

    /// <summary>
    /// The requested payment amount is too high for the provided payment source.
    /// </summary>
    public static readonly ErrorCode AmountTooHigh = new("AMOUNT_TOO_HIGH");

    /// <summary>
    /// The API request references an unsupported instrument type.
    /// </summary>
    public static readonly ErrorCode UnsupportedInstrumentType = new("UNSUPPORTED_INSTRUMENT_TYPE");

    /// <summary>
    /// The requested refund amount exceeds the amount available to refund.
    /// </summary>
    public static readonly ErrorCode RefundAmountInvalid = new("REFUND_AMOUNT_INVALID");

    /// <summary>
    /// The payment already has a pending refund.
    /// </summary>
    public static readonly ErrorCode RefundAlreadyPending = new("REFUND_ALREADY_PENDING");

    /// <summary>
    /// The payment is not refundable. For example, the payment is too old to be refunded.
    /// </summary>
    public static readonly ErrorCode PaymentNotRefundable = new("PAYMENT_NOT_REFUNDABLE");

    /// <summary>
    /// The payment is not refundable because it has been disputed.
    /// </summary>
    public static readonly ErrorCode PaymentNotRefundableDueToDispute = new("PAYMENT_NOT_REFUNDABLE_DUE_TO_DISPUTE");

    /// <summary>
    /// The payment is not refundable because the payment is approved and needs to be completed first before the refund is issued.
    /// </summary>
    public static readonly ErrorCode RefundErrorPaymentNeedsCompletion = new("REFUND_ERROR_PAYMENT_NEEDS_COMPLETION");

    /// <summary>
    /// Request failed - The card issuer declined the refund.
    /// </summary>
    public static readonly ErrorCode RefundDeclined = new("REFUND_DECLINED");

    /// <summary>
    /// The Square account does not have the permissions to process this refund.
    /// </summary>
    public static readonly ErrorCode InsufficientPermissionsForRefund = new("INSUFFICIENT_PERMISSIONS_FOR_REFUND");

    /// <summary>
    /// Generic error - the provided card data is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidCardData = new("INVALID_CARD_DATA");

    /// <summary>
    /// The provided source id was already used to create a card.
    /// </summary>
    public static readonly ErrorCode SourceUsed = new("SOURCE_USED");

    /// <summary>
    /// The provided source id has expired.
    /// </summary>
    public static readonly ErrorCode SourceExpired = new("SOURCE_EXPIRED");

    /// <summary>
    /// The referenced loyalty program reward tier is not supported.
    /// This could happen if the reward tier created in a first party
    /// application is incompatible with the Loyalty API.
    /// </summary>
    public static readonly ErrorCode UnsupportedLoyaltyRewardTier = new("UNSUPPORTED_LOYALTY_REWARD_TIER");

    /// <summary>
    /// Generic error - the given location does not matching what is expected.
    /// </summary>
    public static readonly ErrorCode LocationMismatch = new("LOCATION_MISMATCH");

    /// <summary>
    /// The order attempting to be returned is not yet paid and cannot be returned.
    /// </summary>
    public static readonly ErrorCode OrderUnpaidNotReturnable = new("ORDER_UNPAID_NOT_RETURNABLE");

    /// <summary>
    /// Delay capture of a partial payment is not supported.
    /// </summary>
    public static readonly ErrorCode PartialPaymentDelayCaptureNotSupported = new(
        "PARTIAL_PAYMENT_DELAY_CAPTURE_NOT_SUPPORTED");

    /// <summary>
    /// The provided idempotency key has already been used.
    /// </summary>
    public static readonly ErrorCode IdempotencyKeyReused = new("IDEMPOTENCY_KEY_REUSED");

    /// <summary>
    /// General error - the value provided was unexpected.
    /// </summary>
    public static readonly ErrorCode UnexpectedValue = new("UNEXPECTED_VALUE");

    /// <summary>
    /// The API request is not supported in sandbox.
    /// </summary>
    public static readonly ErrorCode SandboxNotSupported = new("SANDBOX_NOT_SUPPORTED");

    /// <summary>
    /// The provided email address is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidEmailAddress = new("INVALID_EMAIL_ADDRESS");

    /// <summary>
    /// The provided phone number is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidPhoneNumber = new("INVALID_PHONE_NUMBER");

    /// <summary>
    /// The provided checkout URL has expired.
    /// </summary>
    public static readonly ErrorCode CheckoutExpired = new("CHECKOUT_EXPIRED");

    /// <summary>
    /// Bad certificate.
    /// </summary>
    public static readonly ErrorCode BadCertificate = new("BAD_CERTIFICATE");

    /// <summary>
    /// The provided Square-Version is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode InvalidSquareVersionFormat = new("INVALID_SQUARE_VERSION_FORMAT");

    /// <summary>
    /// The provided Square-Version is incompatible with the requested action.
    /// </summary>
    public static readonly ErrorCode ApiVersionIncompatible = new("API_VERSION_INCOMPATIBLE");

    /// <summary>
    /// The transaction requires that a card be present.
    /// </summary>
    public static readonly ErrorCode CardPresenceRequired = new("CARD_PRESENCE_REQUIRED");

    /// <summary>
    /// The API request references an unsupported source type.
    /// </summary>
    public static readonly ErrorCode UnsupportedSourceType = new("UNSUPPORTED_SOURCE_TYPE");

    /// <summary>
    /// The provided card does not match what is expected.
    /// </summary>
    public static readonly ErrorCode CardMismatch = new("CARD_MISMATCH");

    /// <summary>
    /// Generic plaid error
    /// </summary>
    public static readonly ErrorCode PlaidError = new("PLAID_ERROR");

    /// <summary>
    /// Plaid error - ITEM_LOGIN_REQUIRED
    /// </summary>
    public static readonly ErrorCode PlaidErrorItemLoginRequired = new("PLAID_ERROR_ITEM_LOGIN_REQUIRED");

    /// <summary>
    /// Plaid error - RATE_LIMIT
    /// </summary>
    public static readonly ErrorCode PlaidErrorRateLimit = new("PLAID_ERROR_RATE_LIMIT");

    /// <summary>
    /// The provided merchant or location is not enabled to accept
    /// the requested payment source.
    /// </summary>
    public static readonly ErrorCode PaymentSourceNotEnabledForTarget = new("PAYMENT_SOURCE_NOT_ENABLED_FOR_TARGET");

    /// <summary>
    /// The card was declined.
    /// </summary>
    public static readonly ErrorCode CardDeclined = new("CARD_DECLINED");

    /// <summary>
    /// The CVV could not be verified.
    /// </summary>
    public static readonly ErrorCode VerifyCvvFailure = new("VERIFY_CVV_FAILURE");

    /// <summary>
    /// The AVS could not be verified.
    /// </summary>
    public static readonly ErrorCode VerifyAvsFailure = new("VERIFY_AVS_FAILURE");

    /// <summary>
    /// The payment card was declined with a request
    /// for the card holder to call the issuer.
    /// </summary>
    public static readonly ErrorCode CardDeclinedCallIssuer = new("CARD_DECLINED_CALL_ISSUER");

    /// <summary>
    /// The payment card was declined with a request
    /// for additional verification.
    /// </summary>
    public static readonly ErrorCode CardDeclinedVerificationRequired = new("CARD_DECLINED_VERIFICATION_REQUIRED");

    /// <summary>
    /// The card expiration date is either missing or
    /// incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode BadExpiration = new("BAD_EXPIRATION");

    /// <summary>
    /// The card issuer requires that the card be read
    /// using a chip reader.
    /// </summary>
    public static readonly ErrorCode ChipInsertionRequired = new("CHIP_INSERTION_REQUIRED");

    /// <summary>
    /// The card has exhausted its available pin entry
    /// retries set by the card issuer. Resolving the error typically requires the
    /// card holder to contact the card issuer.
    /// </summary>
    public static readonly ErrorCode AllowablePinTriesExceeded = new("ALLOWABLE_PIN_TRIES_EXCEEDED");

    /// <summary>
    /// The card issuer declined the refund.
    /// </summary>
    public static readonly ErrorCode ReservationDeclined = new("RESERVATION_DECLINED");

    /// <summary>
    /// The body parameter is not recognized by the requested endpoint.
    /// </summary>
    public static readonly ErrorCode UnknownBodyParameter = new("UNKNOWN_BODY_PARAMETER");

    /// <summary>
    /// Not Found - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotFound = new("NOT_FOUND");

    /// <summary>
    /// Square could not find the associated Apple Pay certificate.
    /// </summary>
    public static readonly ErrorCode ApplePaymentProcessingCertificateHashNotFound = new(
        "APPLE_PAYMENT_PROCESSING_CERTIFICATE_HASH_NOT_FOUND");

    /// <summary>
    /// Method Not Allowed - a general error occurred.
    /// </summary>
    public static readonly ErrorCode MethodNotAllowed = new("METHOD_NOT_ALLOWED");

    /// <summary>
    /// Not Acceptable - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotAcceptable = new("NOT_ACCEPTABLE");

    /// <summary>
    /// Request Timeout - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RequestTimeout = new("REQUEST_TIMEOUT");

    /// <summary>
    /// Conflict - a general error occurred.
    /// </summary>
    public static readonly ErrorCode Conflict = new("CONFLICT");

    /// <summary>
    /// The target resource is no longer available and this
    /// condition is likely to be permanent.
    /// </summary>
    public static readonly ErrorCode Gone = new("GONE");

    /// <summary>
    /// Request Entity Too Large - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RequestEntityTooLarge = new("REQUEST_ENTITY_TOO_LARGE");

    /// <summary>
    /// Unsupported Media Type - a general error occurred.
    /// </summary>
    public static readonly ErrorCode UnsupportedMediaType = new("UNSUPPORTED_MEDIA_TYPE");

    /// <summary>
    /// Unprocessable Entity - a general error occurred.
    /// </summary>
    public static readonly ErrorCode UnprocessableEntity = new("UNPROCESSABLE_ENTITY");

    /// <summary>
    /// Rate Limited - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RateLimited = new("RATE_LIMITED");

    /// <summary>
    /// Not Implemented - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotImplemented = new("NOT_IMPLEMENTED");

    /// <summary>
    /// Bad Gateway - a general error occurred.
    /// </summary>
    public static readonly ErrorCode BadGateway = new("BAD_GATEWAY");

    /// <summary>
    /// Service Unavailable - a general error occurred.
    /// </summary>
    public static readonly ErrorCode ServiceUnavailable = new("SERVICE_UNAVAILABLE");

    /// <summary>
    /// A temporary internal error occurred. You can safely retry your call
    /// using the same idempotency key.
    /// </summary>
    public static readonly ErrorCode TemporaryError = new("TEMPORARY_ERROR");

    /// <summary>
    /// Gateway Timeout - a general error occurred.
    /// </summary>
    public static readonly ErrorCode GatewayTimeout = new("GATEWAY_TIMEOUT");

    public TResult Match<TResult>(Func<TResult> onInternalServerError,
        Func<TResult> onUnauthorized,
        Func<TResult> onAccessTokenExpired,
        Func<TResult> onAccessTokenRevoked,
        Func<TResult> onClientDisabled,
        Func<TResult> onForbidden,
        Func<TResult> onInsufficientScopes,
        Func<TResult> onApplicationDisabled,
        Func<TResult> onV1Application,
        Func<TResult> onV1AccessToken,
        Func<TResult> onCardProcessingNotEnabled,
        Func<TResult> onMerchantSubscriptionNotFound,
        Func<TResult> onBadRequest,
        Func<TResult> onMissingRequiredParameter,
        Func<TResult> onIncorrectType,
        Func<TResult> onInvalidTime,
        Func<TResult> onInvalidTimeRange,
        Func<TResult> onInvalidValue,
        Func<TResult> onInvalidCursor,
        Func<TResult> onUnknownQueryParameter,
        Func<TResult> onConflictingParameters,
        Func<TResult> onExpectedJsonBody,
        Func<TResult> onInvalidSortOrder,
        Func<TResult> onValueRegexMismatch,
        Func<TResult> onValueTooShort,
        Func<TResult> onValueTooLong,
        Func<TResult> onValueTooLow,
        Func<TResult> onValueTooHigh,
        Func<TResult> onValueEmpty,
        Func<TResult> onArrayLengthTooLong,
        Func<TResult> onArrayLengthTooShort,
        Func<TResult> onArrayEmpty,
        Func<TResult> onExpectedBoolean,
        Func<TResult> onExpectedInteger,
        Func<TResult> onExpectedFloat,
        Func<TResult> onExpectedString,
        Func<TResult> onExpectedObject,
        Func<TResult> onExpectedArray,
        Func<TResult> onExpectedMap,
        Func<TResult> onExpectedBase64EncodedByteArray,
        Func<TResult> onInvalidArrayValue,
        Func<TResult> onInvalidEnumValue,
        Func<TResult> onInvalidContentType,
        Func<TResult> onInvalidFormValue,
        Func<TResult> onCustomerNotFound,
        Func<TResult> onOneInstrumentExpected,
        Func<TResult> onNoFieldsSet,
        Func<TResult> onTooManyMapEntries,
        Func<TResult> onMapKeyLengthTooShort,
        Func<TResult> onMapKeyLengthTooLong,
        Func<TResult> onCustomerMissingName,
        Func<TResult> onCustomerMissingEmail,
        Func<TResult> onInvalidPauseLength,
        Func<TResult> onInvalidDate,
        Func<TResult> onUnsupportedCountry,
        Func<TResult> onUnsupportedCurrency,
        Func<TResult> onAppleTtpPinToken,
        Func<TResult> onCardExpired,
        Func<TResult> onInvalidExpiration,
        Func<TResult> onInvalidExpirationYear,
        Func<TResult> onInvalidExpirationDate,
        Func<TResult> onUnsupportedCardBrand,
        Func<TResult> onUnsupportedEntryMethod,
        Func<TResult> onInvalidEncryptedCard,
        Func<TResult> onInvalidCard,
        Func<TResult> onPaymentAmountMismatch,
        Func<TResult> onGenericDecline,
        Func<TResult> onCvvFailure,
        Func<TResult> onAddressVerificationFailure,
        Func<TResult> onInvalidAccount,
        Func<TResult> onCurrencyMismatch,
        Func<TResult> onInsufficientFunds,
        Func<TResult> onInsufficientPermissions,
        Func<TResult> onCardholderInsufficientPermissions,
        Func<TResult> onInvalidLocation,
        Func<TResult> onTransactionLimit,
        Func<TResult> onVoiceFailure,
        Func<TResult> onPanFailure,
        Func<TResult> onExpirationFailure,
        Func<TResult> onCardNotSupported,
        Func<TResult> onReaderDeclined,
        Func<TResult> onInvalidPin,
        Func<TResult> onMissingPin,
        Func<TResult> onMissingAccountType,
        Func<TResult> onInvalidPostalCode,
        Func<TResult> onInvalidFees,
        Func<TResult> onManuallyEnteredPaymentNotSupported,
        Func<TResult> onPaymentLimitExceeded,
        Func<TResult> onGiftCardAvailableAmount,
        Func<TResult> onAccountUnusable,
        Func<TResult> onBuyerRefusedPayment,
        Func<TResult> onDelayedTransactionExpired,
        Func<TResult> onDelayedTransactionCanceled,
        Func<TResult> onDelayedTransactionCaptured,
        Func<TResult> onDelayedTransactionFailed,
        Func<TResult> onCardTokenExpired,
        Func<TResult> onCardTokenUsed,
        Func<TResult> onAmountTooHigh,
        Func<TResult> onUnsupportedInstrumentType,
        Func<TResult> onRefundAmountInvalid,
        Func<TResult> onRefundAlreadyPending,
        Func<TResult> onPaymentNotRefundable,
        Func<TResult> onPaymentNotRefundableDueToDispute,
        Func<TResult> onRefundErrorPaymentNeedsCompletion,
        Func<TResult> onRefundDeclined,
        Func<TResult> onInsufficientPermissionsForRefund,
        Func<TResult> onInvalidCardData,
        Func<TResult> onSourceUsed,
        Func<TResult> onSourceExpired,
        Func<TResult> onUnsupportedLoyaltyRewardTier,
        Func<TResult> onLocationMismatch,
        Func<TResult> onOrderUnpaidNotReturnable,
        Func<TResult> onPartialPaymentDelayCaptureNotSupported,
        Func<TResult> onIdempotencyKeyReused,
        Func<TResult> onUnexpectedValue,
        Func<TResult> onSandboxNotSupported,
        Func<TResult> onInvalidEmailAddress,
        Func<TResult> onInvalidPhoneNumber,
        Func<TResult> onCheckoutExpired,
        Func<TResult> onBadCertificate,
        Func<TResult> onInvalidSquareVersionFormat,
        Func<TResult> onApiVersionIncompatible,
        Func<TResult> onCardPresenceRequired,
        Func<TResult> onUnsupportedSourceType,
        Func<TResult> onCardMismatch,
        Func<TResult> onPlaidError,
        Func<TResult> onPlaidErrorItemLoginRequired,
        Func<TResult> onPlaidErrorRateLimit,
        Func<TResult> onPaymentSourceNotEnabledForTarget,
        Func<TResult> onCardDeclined,
        Func<TResult> onVerifyCvvFailure,
        Func<TResult> onVerifyAvsFailure,
        Func<TResult> onCardDeclinedCallIssuer,
        Func<TResult> onCardDeclinedVerificationRequired,
        Func<TResult> onBadExpiration,
        Func<TResult> onChipInsertionRequired,
        Func<TResult> onAllowablePinTriesExceeded,
        Func<TResult> onReservationDeclined,
        Func<TResult> onUnknownBodyParameter,
        Func<TResult> onNotFound,
        Func<TResult> onApplePaymentProcessingCertificateHashNotFound,
        Func<TResult> onMethodNotAllowed,
        Func<TResult> onNotAcceptable,
        Func<TResult> onRequestTimeout,
        Func<TResult> onConflict,
        Func<TResult> onGone,
        Func<TResult> onRequestEntityTooLarge,
        Func<TResult> onUnsupportedMediaType,
        Func<TResult> onUnprocessableEntity,
        Func<TResult> onRateLimited,
        Func<TResult> onNotImplemented,
        Func<TResult> onBadGateway,
        Func<TResult> onServiceUnavailable,
        Func<TResult> onTemporaryError,
        Func<TResult> onGatewayTimeout,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InternalServerError => onInternalServerError(),
            _ when this == Unauthorized => onUnauthorized(),
            _ when this == AccessTokenExpired => onAccessTokenExpired(),
            _ when this == AccessTokenRevoked => onAccessTokenRevoked(),
            _ when this == ClientDisabled => onClientDisabled(),
            _ when this == Forbidden => onForbidden(),
            _ when this == InsufficientScopes => onInsufficientScopes(),
            _ when this == ApplicationDisabled => onApplicationDisabled(),
            _ when this == V1Application => onV1Application(),
            _ when this == V1AccessToken => onV1AccessToken(),
            _ when this == CardProcessingNotEnabled => onCardProcessingNotEnabled(),
            _ when this == MerchantSubscriptionNotFound => onMerchantSubscriptionNotFound(),
            _ when this == BadRequest => onBadRequest(),
            _ when this == MissingRequiredParameter => onMissingRequiredParameter(),
            _ when this == IncorrectType => onIncorrectType(),
            _ when this == InvalidTime => onInvalidTime(),
            _ when this == InvalidTimeRange => onInvalidTimeRange(),
            _ when this == InvalidValue => onInvalidValue(),
            _ when this == InvalidCursor => onInvalidCursor(),
            _ when this == UnknownQueryParameter => onUnknownQueryParameter(),
            _ when this == ConflictingParameters => onConflictingParameters(),
            _ when this == ExpectedJsonBody => onExpectedJsonBody(),
            _ when this == InvalidSortOrder => onInvalidSortOrder(),
            _ when this == ValueRegexMismatch => onValueRegexMismatch(),
            _ when this == ValueTooShort => onValueTooShort(),
            _ when this == ValueTooLong => onValueTooLong(),
            _ when this == ValueTooLow => onValueTooLow(),
            _ when this == ValueTooHigh => onValueTooHigh(),
            _ when this == ValueEmpty => onValueEmpty(),
            _ when this == ArrayLengthTooLong => onArrayLengthTooLong(),
            _ when this == ArrayLengthTooShort => onArrayLengthTooShort(),
            _ when this == ArrayEmpty => onArrayEmpty(),
            _ when this == ExpectedBoolean => onExpectedBoolean(),
            _ when this == ExpectedInteger => onExpectedInteger(),
            _ when this == ExpectedFloat => onExpectedFloat(),
            _ when this == ExpectedString => onExpectedString(),
            _ when this == ExpectedObject => onExpectedObject(),
            _ when this == ExpectedArray => onExpectedArray(),
            _ when this == ExpectedMap => onExpectedMap(),
            _ when this == ExpectedBase64EncodedByteArray => onExpectedBase64EncodedByteArray(),
            _ when this == InvalidArrayValue => onInvalidArrayValue(),
            _ when this == InvalidEnumValue => onInvalidEnumValue(),
            _ when this == InvalidContentType => onInvalidContentType(),
            _ when this == InvalidFormValue => onInvalidFormValue(),
            _ when this == CustomerNotFound => onCustomerNotFound(),
            _ when this == OneInstrumentExpected => onOneInstrumentExpected(),
            _ when this == NoFieldsSet => onNoFieldsSet(),
            _ when this == TooManyMapEntries => onTooManyMapEntries(),
            _ when this == MapKeyLengthTooShort => onMapKeyLengthTooShort(),
            _ when this == MapKeyLengthTooLong => onMapKeyLengthTooLong(),
            _ when this == CustomerMissingName => onCustomerMissingName(),
            _ when this == CustomerMissingEmail => onCustomerMissingEmail(),
            _ when this == InvalidPauseLength => onInvalidPauseLength(),
            _ when this == InvalidDate => onInvalidDate(),
            _ when this == UnsupportedCountry => onUnsupportedCountry(),
            _ when this == UnsupportedCurrency => onUnsupportedCurrency(),
            _ when this == AppleTtpPinToken => onAppleTtpPinToken(),
            _ when this == CardExpired => onCardExpired(),
            _ when this == InvalidExpiration => onInvalidExpiration(),
            _ when this == InvalidExpirationYear => onInvalidExpirationYear(),
            _ when this == InvalidExpirationDate => onInvalidExpirationDate(),
            _ when this == UnsupportedCardBrand => onUnsupportedCardBrand(),
            _ when this == UnsupportedEntryMethod => onUnsupportedEntryMethod(),
            _ when this == InvalidEncryptedCard => onInvalidEncryptedCard(),
            _ when this == InvalidCard => onInvalidCard(),
            _ when this == PaymentAmountMismatch => onPaymentAmountMismatch(),
            _ when this == GenericDecline => onGenericDecline(),
            _ when this == CvvFailure => onCvvFailure(),
            _ when this == AddressVerificationFailure => onAddressVerificationFailure(),
            _ when this == InvalidAccount => onInvalidAccount(),
            _ when this == CurrencyMismatch => onCurrencyMismatch(),
            _ when this == InsufficientFunds => onInsufficientFunds(),
            _ when this == InsufficientPermissions => onInsufficientPermissions(),
            _ when this == CardholderInsufficientPermissions => onCardholderInsufficientPermissions(),
            _ when this == InvalidLocation => onInvalidLocation(),
            _ when this == TransactionLimit => onTransactionLimit(),
            _ when this == VoiceFailure => onVoiceFailure(),
            _ when this == PanFailure => onPanFailure(),
            _ when this == ExpirationFailure => onExpirationFailure(),
            _ when this == CardNotSupported => onCardNotSupported(),
            _ when this == ReaderDeclined => onReaderDeclined(),
            _ when this == InvalidPin => onInvalidPin(),
            _ when this == MissingPin => onMissingPin(),
            _ when this == MissingAccountType => onMissingAccountType(),
            _ when this == InvalidPostalCode => onInvalidPostalCode(),
            _ when this == InvalidFees => onInvalidFees(),
            _ when this == ManuallyEnteredPaymentNotSupported => onManuallyEnteredPaymentNotSupported(),
            _ when this == PaymentLimitExceeded => onPaymentLimitExceeded(),
            _ when this == GiftCardAvailableAmount => onGiftCardAvailableAmount(),
            _ when this == AccountUnusable => onAccountUnusable(),
            _ when this == BuyerRefusedPayment => onBuyerRefusedPayment(),
            _ when this == DelayedTransactionExpired => onDelayedTransactionExpired(),
            _ when this == DelayedTransactionCanceled => onDelayedTransactionCanceled(),
            _ when this == DelayedTransactionCaptured => onDelayedTransactionCaptured(),
            _ when this == DelayedTransactionFailed => onDelayedTransactionFailed(),
            _ when this == CardTokenExpired => onCardTokenExpired(),
            _ when this == CardTokenUsed => onCardTokenUsed(),
            _ when this == AmountTooHigh => onAmountTooHigh(),
            _ when this == UnsupportedInstrumentType => onUnsupportedInstrumentType(),
            _ when this == RefundAmountInvalid => onRefundAmountInvalid(),
            _ when this == RefundAlreadyPending => onRefundAlreadyPending(),
            _ when this == PaymentNotRefundable => onPaymentNotRefundable(),
            _ when this == PaymentNotRefundableDueToDispute => onPaymentNotRefundableDueToDispute(),
            _ when this == RefundErrorPaymentNeedsCompletion => onRefundErrorPaymentNeedsCompletion(),
            _ when this == RefundDeclined => onRefundDeclined(),
            _ when this == InsufficientPermissionsForRefund => onInsufficientPermissionsForRefund(),
            _ when this == InvalidCardData => onInvalidCardData(),
            _ when this == SourceUsed => onSourceUsed(),
            _ when this == SourceExpired => onSourceExpired(),
            _ when this == UnsupportedLoyaltyRewardTier => onUnsupportedLoyaltyRewardTier(),
            _ when this == LocationMismatch => onLocationMismatch(),
            _ when this == OrderUnpaidNotReturnable => onOrderUnpaidNotReturnable(),
            _ when this == PartialPaymentDelayCaptureNotSupported => onPartialPaymentDelayCaptureNotSupported(),
            _ when this == IdempotencyKeyReused => onIdempotencyKeyReused(),
            _ when this == UnexpectedValue => onUnexpectedValue(),
            _ when this == SandboxNotSupported => onSandboxNotSupported(),
            _ when this == InvalidEmailAddress => onInvalidEmailAddress(),
            _ when this == InvalidPhoneNumber => onInvalidPhoneNumber(),
            _ when this == CheckoutExpired => onCheckoutExpired(),
            _ when this == BadCertificate => onBadCertificate(),
            _ when this == InvalidSquareVersionFormat => onInvalidSquareVersionFormat(),
            _ when this == ApiVersionIncompatible => onApiVersionIncompatible(),
            _ when this == CardPresenceRequired => onCardPresenceRequired(),
            _ when this == UnsupportedSourceType => onUnsupportedSourceType(),
            _ when this == CardMismatch => onCardMismatch(),
            _ when this == PlaidError => onPlaidError(),
            _ when this == PlaidErrorItemLoginRequired => onPlaidErrorItemLoginRequired(),
            _ when this == PlaidErrorRateLimit => onPlaidErrorRateLimit(),
            _ when this == PaymentSourceNotEnabledForTarget => onPaymentSourceNotEnabledForTarget(),
            _ when this == CardDeclined => onCardDeclined(),
            _ when this == VerifyCvvFailure => onVerifyCvvFailure(),
            _ when this == VerifyAvsFailure => onVerifyAvsFailure(),
            _ when this == CardDeclinedCallIssuer => onCardDeclinedCallIssuer(),
            _ when this == CardDeclinedVerificationRequired => onCardDeclinedVerificationRequired(),
            _ when this == BadExpiration => onBadExpiration(),
            _ when this == ChipInsertionRequired => onChipInsertionRequired(),
            _ when this == AllowablePinTriesExceeded => onAllowablePinTriesExceeded(),
            _ when this == ReservationDeclined => onReservationDeclined(),
            _ when this == UnknownBodyParameter => onUnknownBodyParameter(),
            _ when this == NotFound => onNotFound(),
            _ when this ==
                ApplePaymentProcessingCertificateHashNotFound => onApplePaymentProcessingCertificateHashNotFound(),
            _ when this == MethodNotAllowed => onMethodNotAllowed(),
            _ when this == NotAcceptable => onNotAcceptable(),
            _ when this == RequestTimeout => onRequestTimeout(),
            _ when this == Conflict => onConflict(),
            _ when this == Gone => onGone(),
            _ when this == RequestEntityTooLarge => onRequestEntityTooLarge(),
            _ when this == UnsupportedMediaType => onUnsupportedMediaType(),
            _ when this == UnprocessableEntity => onUnprocessableEntity(),
            _ when this == RateLimited => onRateLimited(),
            _ when this == NotImplemented => onNotImplemented(),
            _ when this == BadGateway => onBadGateway(),
            _ when this == ServiceUnavailable => onServiceUnavailable(),
            _ when this == TemporaryError => onTemporaryError(),
            _ when this == GatewayTimeout => onGatewayTimeout(),
            _ => otherwise(Value)
        };

    public void Match(Action onInternalServerError,
        Action onUnauthorized,
        Action onAccessTokenExpired,
        Action onAccessTokenRevoked,
        Action onClientDisabled,
        Action onForbidden,
        Action onInsufficientScopes,
        Action onApplicationDisabled,
        Action onV1Application,
        Action onV1AccessToken,
        Action onCardProcessingNotEnabled,
        Action onMerchantSubscriptionNotFound,
        Action onBadRequest,
        Action onMissingRequiredParameter,
        Action onIncorrectType,
        Action onInvalidTime,
        Action onInvalidTimeRange,
        Action onInvalidValue,
        Action onInvalidCursor,
        Action onUnknownQueryParameter,
        Action onConflictingParameters,
        Action onExpectedJsonBody,
        Action onInvalidSortOrder,
        Action onValueRegexMismatch,
        Action onValueTooShort,
        Action onValueTooLong,
        Action onValueTooLow,
        Action onValueTooHigh,
        Action onValueEmpty,
        Action onArrayLengthTooLong,
        Action onArrayLengthTooShort,
        Action onArrayEmpty,
        Action onExpectedBoolean,
        Action onExpectedInteger,
        Action onExpectedFloat,
        Action onExpectedString,
        Action onExpectedObject,
        Action onExpectedArray,
        Action onExpectedMap,
        Action onExpectedBase64EncodedByteArray,
        Action onInvalidArrayValue,
        Action onInvalidEnumValue,
        Action onInvalidContentType,
        Action onInvalidFormValue,
        Action onCustomerNotFound,
        Action onOneInstrumentExpected,
        Action onNoFieldsSet,
        Action onTooManyMapEntries,
        Action onMapKeyLengthTooShort,
        Action onMapKeyLengthTooLong,
        Action onCustomerMissingName,
        Action onCustomerMissingEmail,
        Action onInvalidPauseLength,
        Action onInvalidDate,
        Action onUnsupportedCountry,
        Action onUnsupportedCurrency,
        Action onAppleTtpPinToken,
        Action onCardExpired,
        Action onInvalidExpiration,
        Action onInvalidExpirationYear,
        Action onInvalidExpirationDate,
        Action onUnsupportedCardBrand,
        Action onUnsupportedEntryMethod,
        Action onInvalidEncryptedCard,
        Action onInvalidCard,
        Action onPaymentAmountMismatch,
        Action onGenericDecline,
        Action onCvvFailure,
        Action onAddressVerificationFailure,
        Action onInvalidAccount,
        Action onCurrencyMismatch,
        Action onInsufficientFunds,
        Action onInsufficientPermissions,
        Action onCardholderInsufficientPermissions,
        Action onInvalidLocation,
        Action onTransactionLimit,
        Action onVoiceFailure,
        Action onPanFailure,
        Action onExpirationFailure,
        Action onCardNotSupported,
        Action onReaderDeclined,
        Action onInvalidPin,
        Action onMissingPin,
        Action onMissingAccountType,
        Action onInvalidPostalCode,
        Action onInvalidFees,
        Action onManuallyEnteredPaymentNotSupported,
        Action onPaymentLimitExceeded,
        Action onGiftCardAvailableAmount,
        Action onAccountUnusable,
        Action onBuyerRefusedPayment,
        Action onDelayedTransactionExpired,
        Action onDelayedTransactionCanceled,
        Action onDelayedTransactionCaptured,
        Action onDelayedTransactionFailed,
        Action onCardTokenExpired,
        Action onCardTokenUsed,
        Action onAmountTooHigh,
        Action onUnsupportedInstrumentType,
        Action onRefundAmountInvalid,
        Action onRefundAlreadyPending,
        Action onPaymentNotRefundable,
        Action onPaymentNotRefundableDueToDispute,
        Action onRefundErrorPaymentNeedsCompletion,
        Action onRefundDeclined,
        Action onInsufficientPermissionsForRefund,
        Action onInvalidCardData,
        Action onSourceUsed,
        Action onSourceExpired,
        Action onUnsupportedLoyaltyRewardTier,
        Action onLocationMismatch,
        Action onOrderUnpaidNotReturnable,
        Action onPartialPaymentDelayCaptureNotSupported,
        Action onIdempotencyKeyReused,
        Action onUnexpectedValue,
        Action onSandboxNotSupported,
        Action onInvalidEmailAddress,
        Action onInvalidPhoneNumber,
        Action onCheckoutExpired,
        Action onBadCertificate,
        Action onInvalidSquareVersionFormat,
        Action onApiVersionIncompatible,
        Action onCardPresenceRequired,
        Action onUnsupportedSourceType,
        Action onCardMismatch,
        Action onPlaidError,
        Action onPlaidErrorItemLoginRequired,
        Action onPlaidErrorRateLimit,
        Action onPaymentSourceNotEnabledForTarget,
        Action onCardDeclined,
        Action onVerifyCvvFailure,
        Action onVerifyAvsFailure,
        Action onCardDeclinedCallIssuer,
        Action onCardDeclinedVerificationRequired,
        Action onBadExpiration,
        Action onChipInsertionRequired,
        Action onAllowablePinTriesExceeded,
        Action onReservationDeclined,
        Action onUnknownBodyParameter,
        Action onNotFound,
        Action onApplePaymentProcessingCertificateHashNotFound,
        Action onMethodNotAllowed,
        Action onNotAcceptable,
        Action onRequestTimeout,
        Action onConflict,
        Action onGone,
        Action onRequestEntityTooLarge,
        Action onUnsupportedMediaType,
        Action onUnprocessableEntity,
        Action onRateLimited,
        Action onNotImplemented,
        Action onBadGateway,
        Action onServiceUnavailable,
        Action onTemporaryError,
        Action onGatewayTimeout,
        Action<string> otherwise)
    {
        if (this == InternalServerError) onInternalServerError();
        else if (this == Unauthorized) onUnauthorized();
        else if (this == AccessTokenExpired) onAccessTokenExpired();
        else if (this == AccessTokenRevoked) onAccessTokenRevoked();
        else if (this == ClientDisabled) onClientDisabled();
        else if (this == Forbidden) onForbidden();
        else if (this == InsufficientScopes) onInsufficientScopes();
        else if (this == ApplicationDisabled) onApplicationDisabled();
        else if (this == V1Application) onV1Application();
        else if (this == V1AccessToken) onV1AccessToken();
        else if (this == CardProcessingNotEnabled) onCardProcessingNotEnabled();
        else if (this == MerchantSubscriptionNotFound) onMerchantSubscriptionNotFound();
        else if (this == BadRequest) onBadRequest();
        else if (this == MissingRequiredParameter) onMissingRequiredParameter();
        else if (this == IncorrectType) onIncorrectType();
        else if (this == InvalidTime) onInvalidTime();
        else if (this == InvalidTimeRange) onInvalidTimeRange();
        else if (this == InvalidValue) onInvalidValue();
        else if (this == InvalidCursor) onInvalidCursor();
        else if (this == UnknownQueryParameter) onUnknownQueryParameter();
        else if (this == ConflictingParameters) onConflictingParameters();
        else if (this == ExpectedJsonBody) onExpectedJsonBody();
        else if (this == InvalidSortOrder) onInvalidSortOrder();
        else if (this == ValueRegexMismatch) onValueRegexMismatch();
        else if (this == ValueTooShort) onValueTooShort();
        else if (this == ValueTooLong) onValueTooLong();
        else if (this == ValueTooLow) onValueTooLow();
        else if (this == ValueTooHigh) onValueTooHigh();
        else if (this == ValueEmpty) onValueEmpty();
        else if (this == ArrayLengthTooLong) onArrayLengthTooLong();
        else if (this == ArrayLengthTooShort) onArrayLengthTooShort();
        else if (this == ArrayEmpty) onArrayEmpty();
        else if (this == ExpectedBoolean) onExpectedBoolean();
        else if (this == ExpectedInteger) onExpectedInteger();
        else if (this == ExpectedFloat) onExpectedFloat();
        else if (this == ExpectedString) onExpectedString();
        else if (this == ExpectedObject) onExpectedObject();
        else if (this == ExpectedArray) onExpectedArray();
        else if (this == ExpectedMap) onExpectedMap();
        else if (this == ExpectedBase64EncodedByteArray) onExpectedBase64EncodedByteArray();
        else if (this == InvalidArrayValue) onInvalidArrayValue();
        else if (this == InvalidEnumValue) onInvalidEnumValue();
        else if (this == InvalidContentType) onInvalidContentType();
        else if (this == InvalidFormValue) onInvalidFormValue();
        else if (this == CustomerNotFound) onCustomerNotFound();
        else if (this == OneInstrumentExpected) onOneInstrumentExpected();
        else if (this == NoFieldsSet) onNoFieldsSet();
        else if (this == TooManyMapEntries) onTooManyMapEntries();
        else if (this == MapKeyLengthTooShort) onMapKeyLengthTooShort();
        else if (this == MapKeyLengthTooLong) onMapKeyLengthTooLong();
        else if (this == CustomerMissingName) onCustomerMissingName();
        else if (this == CustomerMissingEmail) onCustomerMissingEmail();
        else if (this == InvalidPauseLength) onInvalidPauseLength();
        else if (this == InvalidDate) onInvalidDate();
        else if (this == UnsupportedCountry) onUnsupportedCountry();
        else if (this == UnsupportedCurrency) onUnsupportedCurrency();
        else if (this == AppleTtpPinToken) onAppleTtpPinToken();
        else if (this == CardExpired) onCardExpired();
        else if (this == InvalidExpiration) onInvalidExpiration();
        else if (this == InvalidExpirationYear) onInvalidExpirationYear();
        else if (this == InvalidExpirationDate) onInvalidExpirationDate();
        else if (this == UnsupportedCardBrand) onUnsupportedCardBrand();
        else if (this == UnsupportedEntryMethod) onUnsupportedEntryMethod();
        else if (this == InvalidEncryptedCard) onInvalidEncryptedCard();
        else if (this == InvalidCard) onInvalidCard();
        else if (this == PaymentAmountMismatch) onPaymentAmountMismatch();
        else if (this == GenericDecline) onGenericDecline();
        else if (this == CvvFailure) onCvvFailure();
        else if (this == AddressVerificationFailure) onAddressVerificationFailure();
        else if (this == InvalidAccount) onInvalidAccount();
        else if (this == CurrencyMismatch) onCurrencyMismatch();
        else if (this == InsufficientFunds) onInsufficientFunds();
        else if (this == InsufficientPermissions) onInsufficientPermissions();
        else if (this == CardholderInsufficientPermissions) onCardholderInsufficientPermissions();
        else if (this == InvalidLocation) onInvalidLocation();
        else if (this == TransactionLimit) onTransactionLimit();
        else if (this == VoiceFailure) onVoiceFailure();
        else if (this == PanFailure) onPanFailure();
        else if (this == ExpirationFailure) onExpirationFailure();
        else if (this == CardNotSupported) onCardNotSupported();
        else if (this == ReaderDeclined) onReaderDeclined();
        else if (this == InvalidPin) onInvalidPin();
        else if (this == MissingPin) onMissingPin();
        else if (this == MissingAccountType) onMissingAccountType();
        else if (this == InvalidPostalCode) onInvalidPostalCode();
        else if (this == InvalidFees) onInvalidFees();
        else if (this == ManuallyEnteredPaymentNotSupported) onManuallyEnteredPaymentNotSupported();
        else if (this == PaymentLimitExceeded) onPaymentLimitExceeded();
        else if (this == GiftCardAvailableAmount) onGiftCardAvailableAmount();
        else if (this == AccountUnusable) onAccountUnusable();
        else if (this == BuyerRefusedPayment) onBuyerRefusedPayment();
        else if (this == DelayedTransactionExpired) onDelayedTransactionExpired();
        else if (this == DelayedTransactionCanceled) onDelayedTransactionCanceled();
        else if (this == DelayedTransactionCaptured) onDelayedTransactionCaptured();
        else if (this == DelayedTransactionFailed) onDelayedTransactionFailed();
        else if (this == CardTokenExpired) onCardTokenExpired();
        else if (this == CardTokenUsed) onCardTokenUsed();
        else if (this == AmountTooHigh) onAmountTooHigh();
        else if (this == UnsupportedInstrumentType) onUnsupportedInstrumentType();
        else if (this == RefundAmountInvalid) onRefundAmountInvalid();
        else if (this == RefundAlreadyPending) onRefundAlreadyPending();
        else if (this == PaymentNotRefundable) onPaymentNotRefundable();
        else if (this == PaymentNotRefundableDueToDispute) onPaymentNotRefundableDueToDispute();
        else if (this == RefundErrorPaymentNeedsCompletion) onRefundErrorPaymentNeedsCompletion();
        else if (this == RefundDeclined) onRefundDeclined();
        else if (this == InsufficientPermissionsForRefund) onInsufficientPermissionsForRefund();
        else if (this == InvalidCardData) onInvalidCardData();
        else if (this == SourceUsed) onSourceUsed();
        else if (this == SourceExpired) onSourceExpired();
        else if (this == UnsupportedLoyaltyRewardTier) onUnsupportedLoyaltyRewardTier();
        else if (this == LocationMismatch) onLocationMismatch();
        else if (this == OrderUnpaidNotReturnable) onOrderUnpaidNotReturnable();
        else if (this == PartialPaymentDelayCaptureNotSupported) onPartialPaymentDelayCaptureNotSupported();
        else if (this == IdempotencyKeyReused) onIdempotencyKeyReused();
        else if (this == UnexpectedValue) onUnexpectedValue();
        else if (this == SandboxNotSupported) onSandboxNotSupported();
        else if (this == InvalidEmailAddress) onInvalidEmailAddress();
        else if (this == InvalidPhoneNumber) onInvalidPhoneNumber();
        else if (this == CheckoutExpired) onCheckoutExpired();
        else if (this == BadCertificate) onBadCertificate();
        else if (this == InvalidSquareVersionFormat) onInvalidSquareVersionFormat();
        else if (this == ApiVersionIncompatible) onApiVersionIncompatible();
        else if (this == CardPresenceRequired) onCardPresenceRequired();
        else if (this == UnsupportedSourceType) onUnsupportedSourceType();
        else if (this == CardMismatch) onCardMismatch();
        else if (this == PlaidError) onPlaidError();
        else if (this == PlaidErrorItemLoginRequired) onPlaidErrorItemLoginRequired();
        else if (this == PlaidErrorRateLimit) onPlaidErrorRateLimit();
        else if (this == PaymentSourceNotEnabledForTarget) onPaymentSourceNotEnabledForTarget();
        else if (this == CardDeclined) onCardDeclined();
        else if (this == VerifyCvvFailure) onVerifyCvvFailure();
        else if (this == VerifyAvsFailure) onVerifyAvsFailure();
        else if (this == CardDeclinedCallIssuer) onCardDeclinedCallIssuer();
        else if (this == CardDeclinedVerificationRequired) onCardDeclinedVerificationRequired();
        else if (this == BadExpiration) onBadExpiration();
        else if (this == ChipInsertionRequired) onChipInsertionRequired();
        else if (this == AllowablePinTriesExceeded) onAllowablePinTriesExceeded();
        else if (this == ReservationDeclined) onReservationDeclined();
        else if (this == UnknownBodyParameter) onUnknownBodyParameter();
        else if (this == NotFound) onNotFound();
        else if (this ==
            ApplePaymentProcessingCertificateHashNotFound) onApplePaymentProcessingCertificateHashNotFound();
        else if (this == MethodNotAllowed) onMethodNotAllowed();
        else if (this == NotAcceptable) onNotAcceptable();
        else if (this == RequestTimeout) onRequestTimeout();
        else if (this == Conflict) onConflict();
        else if (this == Gone) onGone();
        else if (this == RequestEntityTooLarge) onRequestEntityTooLarge();
        else if (this == UnsupportedMediaType) onUnsupportedMediaType();
        else if (this == UnprocessableEntity) onUnprocessableEntity();
        else if (this == RateLimited) onRateLimited();
        else if (this == NotImplemented) onNotImplemented();
        else if (this == BadGateway) onBadGateway();
        else if (this == ServiceUnavailable) onServiceUnavailable();
        else if (this == TemporaryError) onTemporaryError();
        else if (this == GatewayTimeout) onGatewayTimeout();
        else otherwise(Value);
    }
}
