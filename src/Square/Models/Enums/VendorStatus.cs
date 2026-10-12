using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the <see href="entity:Vendor">Vendor</see>,
/// whether a <see href="entity:Vendor">Vendor</see> is active or inactive.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorStatus>))]
public sealed record VendorStatus : OpenStringEnum<VendorStatus>
{
    private VendorStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Vendor is active and can receive purchase orders.
    /// </summary>
    public static readonly VendorStatus Active = new("ACTIVE");

    /// <summary>
    /// Vendor is inactive and cannot receive purchase orders.
    /// </summary>
    public static readonly VendorStatus Inactive = new("INACTIVE");

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
