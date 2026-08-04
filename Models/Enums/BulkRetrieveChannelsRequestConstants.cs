using System.Text.Json.Serialization;
using Square.Core.Enum;

namespace Square.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BulkRetrieveChannelsRequestConstants>))]
public sealed record BulkRetrieveChannelsRequestConstants : StringEnum<BulkRetrieveChannelsRequestConstants>
{
    private BulkRetrieveChannelsRequestConstants(string value) : base(value)
    {
    }

    public static readonly BulkRetrieveChannelsRequestConstants MaxBatchSize = new("MAX_BATCH_SIZE");

    public static BulkRetrieveChannelsRequestConstants FromValue(string value) => FromValueCore(value);
}
