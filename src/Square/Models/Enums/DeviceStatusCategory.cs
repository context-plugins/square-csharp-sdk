using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DeviceStatusCategory>))]
public sealed record DeviceStatusCategory : OpenStringEnum<DeviceStatusCategory>
{
    private DeviceStatusCategory(string value) : base(value)
    {
    }

    public static readonly DeviceStatusCategory Available = new("AVAILABLE");

    public static readonly DeviceStatusCategory NeedsAttention = new("NEEDS_ATTENTION");

    public static readonly DeviceStatusCategory Offline = new("OFFLINE");

    public TResult Match<TResult>(Func<TResult> onAvailable,
        Func<TResult> onNeedsAttention,
        Func<TResult> onOffline,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == NeedsAttention => onNeedsAttention(),
            _ when this == Offline => onOffline(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onNeedsAttention, Action onOffline, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == NeedsAttention) onNeedsAttention();
        else if (this == Offline) onOffline();
        else otherwise(Value);
    }
}
