using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the Employee being retrieved.
/// <para>
/// DEPRECATED at version 2020-08-26. Replaced by <see href="entity:TeamMemberStatus">TeamMemberStatus</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmployeeStatus>))]
public sealed record EmployeeStatus : OpenStringEnum<EmployeeStatus>
{
    private EmployeeStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Specifies that the employee is in the Active state.
    /// </summary>
    public static readonly EmployeeStatus Active = new("ACTIVE");

    /// <summary>
    /// Specifies that the employee is in the Inactive state.
    /// </summary>
    public static readonly EmployeeStatus Inactive = new("INACTIVE");

    public TResult Match<TResult>(Func<TResult> onActive, Func<TResult> onInactive, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else otherwise(Value);
    }
}
