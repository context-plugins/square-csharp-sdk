using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The category of the seller’s cancellation policy.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsCancellationPolicy>))]
public sealed record BusinessAppointmentSettingsCancellationPolicy : OpenStringEnum<BusinessAppointmentSettingsCancellationPolicy>
{
    private BusinessAppointmentSettingsCancellationPolicy(string value) : base(value)
    {
    }

    /// <summary>
    /// Cancellations are treated as no shows and may incur a fee as specified by <c>cancellation_fee_money</c>.
    /// </summary>
    public static readonly BusinessAppointmentSettingsCancellationPolicy CancellationTreatedAsNoShow = new(
        "CANCELLATION_TREATED_AS_NO_SHOW");

    /// <summary>
    /// Cancellations follow the seller-specified policy that is described in free-form text and not enforced automatically by Square.
    /// </summary>
    public static readonly BusinessAppointmentSettingsCancellationPolicy CustomPolicy = new("CUSTOM_POLICY");

    public TResult Match<TResult>(Func<TResult> onCancellationTreatedAsNoShow,
        Func<TResult> onCustomPolicy,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CancellationTreatedAsNoShow => onCancellationTreatedAsNoShow(),
            _ when this == CustomPolicy => onCustomPolicy(),
            _ => otherwise(Value)
        };

    public void Match(Action onCancellationTreatedAsNoShow, Action onCustomPolicy, Action<string> otherwise)
    {
        if (this == CancellationTreatedAsNoShow) onCancellationTreatedAsNoShow();
        else if (this == CustomPolicy) onCustomPolicy();
        else otherwise(Value);
    }
}
