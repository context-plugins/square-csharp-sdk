using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Types of daily appointment limits.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType>))]
public sealed record BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType : OpenStringEnum<BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType>
{
    private BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType(string value) : base(value)
    {
    }

    /// <summary>
    /// The maximum number of daily appointments is set on a per team member basis.
    /// </summary>
    public static readonly BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType PerTeamMember = new(
        "PER_TEAM_MEMBER");

    /// <summary>
    /// The maximum number of daily appointments is set on a per location basis.
    /// </summary>
    public static readonly BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType PerLocation = new("PER_LOCATION");

    public TResult Match<TResult>(Func<TResult> onPerTeamMember,
        Func<TResult> onPerLocation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PerTeamMember => onPerTeamMember(),
            _ when this == PerLocation => onPerLocation(),
            _ => otherwise(Value)
        };

    public void Match(Action onPerTeamMember, Action onPerLocation, Action<string> otherwise)
    {
        if (this == PerTeamMember) onPerTeamMember();
        else if (this == PerLocation) onPerLocation();
        else otherwise(Value);
    }
}
