using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the possible pay types that a job can be assigned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<JobAssignmentPayType>))]
public sealed record JobAssignmentPayType : OpenStringEnum<JobAssignmentPayType>
{
    private JobAssignmentPayType(string value) : base(value)
    {
    }

    /// <summary>
    /// The job does not have a defined pay type.
    /// </summary>
    public static readonly JobAssignmentPayType None = new("NONE");

    /// <summary>
    /// The job pays an hourly rate.
    /// </summary>
    public static readonly JobAssignmentPayType Hourly = new("HOURLY");

    /// <summary>
    /// The job pays an annual salary.
    /// </summary>
    public static readonly JobAssignmentPayType Salary = new("SALARY");

    public TResult Match<TResult>(Func<TResult> onNone,
        Func<TResult> onHourly,
        Func<TResult> onSalary,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == None => onNone(),
            _ when this == Hourly => onHourly(),
            _ when this == Salary => onSalary(),
            _ => otherwise(Value)
        };

    public void Match(Action onNone, Action onHourly, Action onSalary, Action<string> otherwise)
    {
        if (this == None) onNone();
        else if (this == Hourly) onHourly();
        else if (this == Salary) onSalary();
        else otherwise(Value);
    }
}
