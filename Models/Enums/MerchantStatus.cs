using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MerchantStatus>))]
public sealed record MerchantStatus : StringEnum<MerchantStatus>
{
    private MerchantStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// A fully operational merchant account. The merchant can interact with Square products and APIs.
    /// </summary>
    public static readonly MerchantStatus Active = new("ACTIVE");

    /// <summary>
    /// A functionally limited merchant account. The merchant can only have limited interaction
    /// via Square APIs. The merchant cannot log in or access the seller dashboard.
    /// </summary>
    public static readonly MerchantStatus Inactive = new("INACTIVE");

    public static MerchantStatus FromValue(string value) => FromValueCore(value);
}
