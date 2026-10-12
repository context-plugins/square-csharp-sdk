using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// Enumerates the possible statuses the team member can have within a business.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TeamMemberStatus>))]
public sealed record TeamMemberStatus : OpenStringEnum<TeamMemberStatus>
{
    private TeamMemberStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The team member can sign in to Point of Sale and the Seller Dashboard.
    /// </summary>
    public static readonly TeamMemberStatus Active = new("ACTIVE");

    /// <summary>
    /// The team member can no longer sign in to Point of Sale or the Seller Dashboard,
    /// but the team member's sales reports remain available.
    /// </summary>
    public static readonly TeamMemberStatus Inactive = new("INACTIVE");

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
