using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TenderSquareAccountDetailsStatus>))]
public sealed record TenderSquareAccountDetailsStatus : StringEnum<TenderSquareAccountDetailsStatus>
{
    private TenderSquareAccountDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The Square Account payment has been authorized but not yet captured.
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Authorized = new("AUTHORIZED");

    /// <summary>
    /// The Square Account payment was authorized and subsequently captured (i.e., completed).
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Captured = new("CAPTURED");

    /// <summary>
    /// The Square Account payment was authorized and subsequently voided (i.e., canceled).
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Voided = new("VOIDED");

    /// <summary>
    /// The Square Account payment failed.
    /// </summary>
    public static readonly TenderSquareAccountDetailsStatus Failed = new("FAILED");

    public static TenderSquareAccountDetailsStatus FromValue(string value) => FromValueCore(value);
}
