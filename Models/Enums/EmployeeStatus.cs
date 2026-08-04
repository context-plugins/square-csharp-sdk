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
public sealed record EmployeeStatus : StringEnum<EmployeeStatus>
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

    public static EmployeeStatus FromValue(string value) => FromValueCore(value);
}
