using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A Felica card's "sub-brand"--the actual brand on the Felica card
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FelicaDetailsFelicaBrand>))]
public sealed record FelicaDetailsFelicaBrand : StringEnum<FelicaDetailsFelicaBrand>
{
    private FelicaDetailsFelicaBrand(string value) : base(value)
    {
    }

    public static readonly FelicaDetailsFelicaBrand Unknown = new("UNKNOWN");

    public static readonly FelicaDetailsFelicaBrand FelicaId = new("FELICA_ID");

    public static readonly FelicaDetailsFelicaBrand FelicaTransportation = new("FELICA_TRANSPORTATION");

    public static readonly FelicaDetailsFelicaBrand FelicaQp = new("FELICA_QP");

    public static FelicaDetailsFelicaBrand FromValue(string value) => FromValueCore(value);
}
