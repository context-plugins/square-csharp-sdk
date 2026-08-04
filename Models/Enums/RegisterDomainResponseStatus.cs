using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The status of the domain registration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RegisterDomainResponseStatus>))]
public sealed record RegisterDomainResponseStatus : StringEnum<RegisterDomainResponseStatus>
{
    private RegisterDomainResponseStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The domain is added, but not verified.
    /// </summary>
    public static readonly RegisterDomainResponseStatus Pending = new("PENDING");

    /// <summary>
    /// The domain is added and verified. It can be used to accept Apple Pay transactions.
    /// </summary>
    public static readonly RegisterDomainResponseStatus Verified = new("VERIFIED");

    public static RegisterDomainResponseStatus FromValue(string value) => FromValueCore(value);
}
