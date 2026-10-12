using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

/// <summary>
/// The operation that can be performed against a vendor to cause the event to be published.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VendorUpdatedEventObjectOperation>))]
public sealed record VendorUpdatedEventObjectOperation : OpenStringEnum<VendorUpdatedEventObjectOperation>
{
    private VendorUpdatedEventObjectOperation(string value) : base(value)
    {
    }

    public static readonly VendorUpdatedEventObjectOperation Updated = new("UPDATED");

    public TResult Match<TResult>(Func<TResult> onUpdated, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Updated => onUpdated(),
            _ => otherwise(Value)
        };

    public void Match(Action onUpdated, Action<string> otherwise)
    {
        if (this == Updated) onUpdated();
        else otherwise(Value);
    }
}
