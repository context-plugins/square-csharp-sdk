using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// DeviceCode.Status enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceCodeStatus>))]
public sealed record DeviceCodeStatus : OpenStringEnum<DeviceCodeStatus>
{
    private DeviceCodeStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The status cannot be determined or does not exist.
    /// </summary>
    public static readonly DeviceCodeStatus Unknown = new("UNKNOWN");

    /// <summary>
    /// The device code is just created and unpaired.
    /// </summary>
    public static readonly DeviceCodeStatus Unpaired = new("UNPAIRED");

    /// <summary>
    /// The device code has been signed in and paired to a device.
    /// </summary>
    public static readonly DeviceCodeStatus Paired = new("PAIRED");

    /// <summary>
    /// The device code was unpaired and expired before it was paired.
    /// </summary>
    public static readonly DeviceCodeStatus Expired = new("EXPIRED");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onUnpaired,
        Func<TResult> onPaired,
        Func<TResult> onExpired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Unpaired => onUnpaired(),
            _ when this == Paired => onPaired(),
            _ when this == Expired => onExpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown, Action onUnpaired, Action onPaired, Action onExpired, Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Unpaired) onUnpaired();
        else if (this == Paired) onPaired();
        else if (this == Expired) onExpired();
        else otherwise(Value);
    }
}
