using System;
using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BulkRetrieveChannelsRequestConstants>))]
public sealed record BulkRetrieveChannelsRequestConstants : OpenStringEnum<BulkRetrieveChannelsRequestConstants>
{
    private BulkRetrieveChannelsRequestConstants(string value) : base(value)
    {
    }

    public static readonly BulkRetrieveChannelsRequestConstants MaxBatchSize = new("MAX_BATCH_SIZE");

    public TResult Match<TResult>(Func<TResult> onMaxBatchSize, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MaxBatchSize => onMaxBatchSize(),
            _ => otherwise(Value)
        };

    public void Match(Action onMaxBatchSize, Action<string> otherwise)
    {
        if (this == MaxBatchSize) onMaxBatchSize();
        else otherwise(Value);
    }
}
