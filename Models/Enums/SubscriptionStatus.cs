using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported subscription statuses.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionStatus>))]
public sealed record SubscriptionStatus : StringEnum<SubscriptionStatus>
{
    private SubscriptionStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The subscription is pending to start in the future.
    /// </summary>
    public static readonly SubscriptionStatus Pending = new("PENDING");

    /// <summary>
    /// The subscription is active.
    /// </summary>
    public static readonly SubscriptionStatus Active = new("ACTIVE");

    /// <summary>
    /// The subscription is canceled.
    /// </summary>
    public static readonly SubscriptionStatus Canceled = new("CANCELED");

    /// <summary>
    /// The subscription is deactivated.
    /// </summary>
    public static readonly SubscriptionStatus Deactivated = new("DEACTIVATED");

    /// <summary>
    /// The subscription is paused.
    /// </summary>
    public static readonly SubscriptionStatus Paused = new("PAUSED");

    /// <summary>
    /// The subscription has completed all of its phases.
    /// </summary>
    public static readonly SubscriptionStatus Completed = new("COMPLETED");

    public static SubscriptionStatus FromValue(string value) => FromValueCore(value);
}
