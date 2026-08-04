using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Square.Models.Enums;

namespace Square.Models;

/// <summary>
/// Represents a subscription purchased by a customer.
/// <para>
/// For more information, see
/// <see href="https://developer.squareup.com/docs/subscriptions-api/manage-subscriptions">Manage Subscriptions</see>.
/// </para>
/// </summary>
public record Subscription
{
    /// <summary>
    /// The Square-assigned ID of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the location associated with the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the subscribed-to <see href="entity:CatalogSubscriptionPlanVariation">subscription plan variation</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_variation_id")]
    public string? PlanVariationId { get; init; }

    /// <summary>
    /// The ID of the subscribing <see href="entity:Customer">customer</see> profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date (for example, 2013-01-15) to start the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date (for example, 2013-01-15) to cancel the subscription,
    /// when the subscription status changes to <c>CANCELED</c> and the subscription billing stops.
    /// <para>
    /// If this field is not set, the subscription ends according its subscription plan.
    /// </para>
    /// <para>
    /// This field cannot be updated, other than being cleared.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_date")]
    public string? CanceledDate { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date up to when the subscriber is invoiced for the
    /// subscription.
    /// <para>
    /// After the invoice is sent for a given billing period,
    /// this date will be the last day of the billing period.
    /// For example,
    /// suppose for the month of May a subscriber gets an invoice
    /// (or charged the card) on May 1. For the monthly billing scenario,
    /// this date is then set to May 31.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("charged_through_date")]
    public string? ChargedThroughDate { get; init; }

    /// <summary>
    /// Supported subscription statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public SubscriptionStatus? Status { get; init; }

    /// <summary>
    /// The tax amount applied when billing the subscription. The
    /// percentage is expressed in decimal form, using a <c>'.'</c> as the decimal
    /// separator and without a <c>'%'</c> sign. For example, a value of <c>7.5</c>
    /// corresponds to 7.5%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_percentage")]
    public string? TaxPercentage { get; init; }

    /// <summary>
    /// The IDs of the <see href="entity:Invoice">invoices</see> created for the
    /// subscription, listed in order when the invoices were created
    /// (newest invoices appear first).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_ids")]
    public IReadOnlyList<string>? InvoiceIds { get; init; }

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
    /// The version of the object. When updating an object, the version
    /// supplied must match the version in the database, otherwise the write will
    /// be rejected as conflicting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }

    /// <summary>
    /// The timestamp when the subscription was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The ID of the <see href="entity:Customer">subscriber's</see> <see href="entity:Card">card</see>
    /// used to charge for the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    public string? CardId { get; init; }

    /// <summary>
    /// Timezone that will be used in date calculations for the subscription.
    /// Defaults to the timezone of the location based on <c>location_id</c>.
    /// Format: the IANA Timezone Database identifier for the location timezone (for example, <c>America/Los_Angeles</c>).
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
    /// The list of scheduled actions on this subscription. It is set only in the response from
    /// <see href="api-endpoint:Subscriptions-RetrieveSubscription">RetrieveSubscription</see> with the query parameter
    /// of <c>include=actions</c> or from
    /// <see href="api-endpoint:Subscriptions-SearchSubscriptions">SearchSubscriptions</see> with the input parameter
    /// of <c>include:["actions"]</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actions")]
    public IReadOnlyList<SubscriptionAction?>? Actions { get; init; }

    /// <summary>
    /// The day of the month on which the subscription will issue invoices and publish orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly_billing_anchor_date")]
    public int? MonthlyBillingAnchorDate { get; init; }

    /// <summary>
    /// array of phases for this subscription
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phases")]
    public IReadOnlyList<Phase>? Phases { get; init; }

    /// <summary>
    /// The <c>YYYY-MM-DD</c>-formatted date when the subscription enters a terminal state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_date")]
    public string? CompletedDate { get; init; }
}
