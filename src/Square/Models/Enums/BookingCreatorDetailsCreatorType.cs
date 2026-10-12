using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Supported types of a booking creator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingCreatorDetailsCreatorType>))]
public sealed record BookingCreatorDetailsCreatorType : OpenStringEnum<BookingCreatorDetailsCreatorType>
{
    private BookingCreatorDetailsCreatorType(string value) : base(value)
    {
    }

    /// <summary>
    /// The creator is of the seller type.
    /// </summary>
    public static readonly BookingCreatorDetailsCreatorType TeamMember = new("TEAM_MEMBER");

    /// <summary>
    /// The creator is of the buyer type.
    /// </summary>
    public static readonly BookingCreatorDetailsCreatorType Customer = new("CUSTOMER");

    public TResult Match<TResult>(Func<TResult> onTeamMember,
        Func<TResult> onCustomer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TeamMember => onTeamMember(),
            _ when this == Customer => onCustomer(),
            _ => otherwise(Value)
        };

    public void Match(Action onTeamMember, Action onCustomer, Action<string> otherwise)
    {
        if (this == TeamMember) onTeamMember();
        else if (this == Customer) onCustomer();
        else otherwise(Value);
    }
}
