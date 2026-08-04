using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TenderBuyNowPayLaterDetailsStatus>))]
public sealed record TenderBuyNowPayLaterDetailsStatus : StringEnum<TenderBuyNowPayLaterDetailsStatus>
{
    private TenderBuyNowPayLaterDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The buy now pay later payment has been authorized but not yet captured.
    /// </summary>
    public static readonly TenderBuyNowPayLaterDetailsStatus Authorized = new("AUTHORIZED");

    /// <summary>
    /// The buy now pay later payment was authorized and subsequently captured (i.e., completed).
    /// </summary>
    public static readonly TenderBuyNowPayLaterDetailsStatus Captured = new("CAPTURED");

    /// <summary>
    /// The buy now pay later payment was authorized and subsequently voided (i.e., canceled).
    /// </summary>
    public static readonly TenderBuyNowPayLaterDetailsStatus Voided = new("VOIDED");

    /// <summary>
    /// The buy now pay later payment failed.
    /// </summary>
    public static readonly TenderBuyNowPayLaterDetailsStatus Failed = new("FAILED");

    public static TenderBuyNowPayLaterDetailsStatus FromValue(string value) => FromValueCore(value);
}
