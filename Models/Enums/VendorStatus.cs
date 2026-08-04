using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the <see href="entity:Vendor">Vendor</see>,
/// whether a <see href="entity:Vendor">Vendor</see> is active or inactive.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorStatus>))]
public sealed record VendorStatus : StringEnum<VendorStatus>
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

    public static VendorStatus FromValue(string value) => FromValueCore(value);
}
