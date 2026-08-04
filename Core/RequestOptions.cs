using Microsoft.Extensions.Logging;

namespace Square.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
