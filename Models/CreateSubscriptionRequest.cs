using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Core.Models;
using Square.Core.Validation.Attributes;

namespace Square.Models;

/// <summary>
/// Defines input parameters in a request to the
/// <see href="api-endpoint:Subscriptions-CreateSubscription">CreateSubscription</see> endpoint.
/// </summary>
public record CreateSubscriptionRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateSubscription</c> request.
    /// If you do not provide a unique string (or provide an empty string as the value),
    /// the endpoint treats each request as independent.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/common-api-patterns/idempotency">Idempotency keys</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the location the subscription is associated with.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/docs/subscriptions-api/plans-and-variations#plan-variations">subscription plan variation</see> created using the Catalog API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_variation_id")]
    public string? PlanVariationId { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Customer">customer</see> subscribing to the subscription plan variation.
    /// </summary>
    [JsonPropertyName("customer_id")]
    [MinLength(1)]
    public required string CustomerId { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date to start the subscription.
    /// If it is unspecified, the subscription starts immediately.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the newly created subscription is scheduled for cancellation.
    /// <para>
    /// This date overrides the cancellation date set in the plan variation configuration.
    /// If the cancellation date is earlier than the end date of a subscription cycle, the subscription stops
    /// at the canceled date and the subscriber is sent a prorated invoice at the beginning of the canceled cycle.
    /// </para>
    /// <para>
    /// When the subscription plan of the newly created subscription has a fixed number of cycles and the <c>canceled_date</c>
    /// occurs before the subscription plan completes, the specified <c>canceled_date</c> sets the date when the subscription
    /// stops through the end of the last cycle.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_date")]
    public string? CanceledDate { get; init; }

    /// <summary>
    /// The tax to add when billing the subscription.
    /// The percentage is expressed in decimal form, using a <c>'.'</c> as the decimal
    /// separator and without a <c>'%'</c> sign. For example, a value of 7.5
    /// corresponds to 7.5%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_percentage")]
    [MaxLength(10)]
    public string? TaxPercentage { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_override_money")]
    public Money? PriceOverrideMoney { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Customer">subscriber's</see> <see href="entity:Card">card</see> to charge.
    /// If it is not specified, the subscriber receives an invoice via email with a link to pay for their subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    public string? CardId { get; init; }

    /// <summary>
    /// The timezone that is used in date calculations for the subscription. If unset, defaults to
    /// the location timezone. If a timezone is not configured for the location, defaults to "America/New_York".
    /// Format: the IANA Timezone Database identifier for the location timezone. For
    /// a list of time zones, see <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">List of tz database time zones</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The origination details of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public SubscriptionSource? Source { get; init; }

    /// <summary>
    /// The day-of-the-month to change the billing date to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    [Minimum(1)]
    [Maximum(31)]
    public int? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// array of phases for this subscription
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<Phase>? Phases { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
