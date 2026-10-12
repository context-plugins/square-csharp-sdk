using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// A Felica card's "sub-brand"--the actual brand on the Felica card
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FelicaDetailsFelicaBrand>))]
public sealed record FelicaDetailsFelicaBrand : OpenStringEnum<FelicaDetailsFelicaBrand>
{
    private FelicaDetailsFelicaBrand(string value) : base(value)
    {
    }

    public static readonly FelicaDetailsFelicaBrand Unknown = new("UNKNOWN");

    public static readonly FelicaDetailsFelicaBrand FelicaId = new("FELICA_ID");

    public static readonly FelicaDetailsFelicaBrand FelicaTransportation = new("FELICA_TRANSPORTATION");

    public static readonly FelicaDetailsFelicaBrand FelicaQp = new("FELICA_QP");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onFelicaId,
        Func<TResult> onFelicaTransportation,
        Func<TResult> onFelicaQp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == FelicaId => onFelicaId(),
            _ when this == FelicaTransportation => onFelicaTransportation(),
            _ when this == FelicaQp => onFelicaQp(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onFelicaId,
        Action onFelicaTransportation,
        Action onFelicaQp,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == FelicaId) onFelicaId();
        else if (this == FelicaTransportation) onFelicaTransportation();
        else if (this == FelicaQp) onFelicaQp();
        else otherwise(Value);
    }
}
