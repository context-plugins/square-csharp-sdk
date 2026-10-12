using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The operation that can be performed against a vendor to cause the event to be published.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorCreatedEventObjectOperation>))]
public sealed record VendorCreatedEventObjectOperation : OpenStringEnum<VendorCreatedEventObjectOperation>
{
    private VendorCreatedEventObjectOperation(string value) : base(value)
    {
    }

    public static readonly VendorCreatedEventObjectOperation Created = new("CREATED");

    public TResult Match<TResult>(Func<TResult> onCreated, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated, Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else otherwise(Value);
    }
}
