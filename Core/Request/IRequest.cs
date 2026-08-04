using System.Net.Http;

namespace Square.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}